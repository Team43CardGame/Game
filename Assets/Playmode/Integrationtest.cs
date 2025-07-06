using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using Unity.Netcode;
using System.Collections;
using System.Linq;

public class CardGameIntegrationTests
{
    private GameObject serverObject;
    private GameObject clientObject;
    private NetworkManager serverManager;
    private NetworkManager clientManager;
    private GameManager gameManager;
    private Player player;

    [SetUp]
    public void Setup()
    {
        serverObject = new GameObject("Server");
        serverManager = serverObject.AddComponent<NetworkManager>();
        gameManager = serverObject.AddComponent<GameManager>();
        serverManager.NetworkConfig = new NetworkConfig();
        
        clientObject = new GameObject("Client");
        clientManager = clientObject.AddComponent<NetworkManager>();
        player = clientObject.AddComponent<Player>();
        clientManager.NetworkConfig = new NetworkConfig();

        // Временный префаб для тестов
        GameObject tempPlayerPrefab = new GameObject("TempPlayerPrefab");
        tempPlayerPrefab.AddComponent<Player>();
        tempPlayerPrefab.AddComponent<NetworkObject>();
        gameManager.playerPrefab = tempPlayerPrefab;

        // Временный префаб для prepRenderPrefab (если нужен)
        GameObject tempPrepRenderPrefab = new GameObject("TempPrepRenderPrefab");
        tempPrepRenderPrefab.AddComponent<PrepRenderer>();
        tempPrepRenderPrefab.AddComponent<NetworkObject>();
        gameManager.prepRenderPrefab = tempPrepRenderPrefab;

        // Временный префаб для deckPrefab (если нужен)
        GameObject tempDeckPrefab = new GameObject("TempDeckPrefab");
        tempDeckPrefab.AddComponent<CardDeckScript>();
        tempDeckPrefab.AddComponent<NetworkObject>();
        if (player.handScript != null)
        {
            player.handScript.deckPrefab = tempDeckPrefab;
        }
    }

    [TearDown]
    public void TearDown()
    {
        NetworkManager.Singleton.Shutdown();
        Object.DestroyImmediate(serverObject);
        Object.DestroyImmediate(clientObject);
    }

    [Test]
    public IEnumerator Test_ClientConnectsToServer()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f); // Увеличено для CI
        Assert.IsTrue(clientManager.IsConnectedClient, "Клиент не подключился к серверу!");
        Assert.AreEqual(1, serverManager.ConnectedClients.Count, "Сервер не зарегистрировал клиента!");
    }

    [Test]
    public IEnumerator Test_GameInitialization()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f);
        Assert.IsNotNull(gameManager.playerCards, "Массив карт игроков не инициализирован!");
        Assert.AreEqual(1, gameManager.playerCount, "Количество игроков не соответствует!");
        Assert.AreEqual(0, gameManager.currentTurn, "Начальный ход не установлен!");
    }

    [Test]
    public IEnumerator Test_CardDistribution()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f);
        Assert.IsNotNull(player.handCards, "Карты в руке игрока не инициализированы!");
        Assert.AreEqual(12, player.handCards.Sum(), "Неверное количество карт в руке!");
    }

    [Test]
    public IEnumerator Test_CardSelection()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f);
        player.TakeTurn(true);
        player.Select(1); // Желтая карта
        Assert.AreEqual(1, player.selected, "Карта не выбрана корректно!");
    }

    [Test]
    public IEnumerator Test_CardPlacement()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f);
        player.TakeTurn(true);
        player.Select(0); // Красная карта
        player.MoveCardServerRpc(0, 0, true);
        yield return new WaitForSeconds(1f);
        Assert.AreEqual(1, gameManager.playerCards[0, 1, 0], "Карта не размещена в prep!");
    }

    [Test]
    public IEnumerator Test_SpellCasting()
    {
        serverManager.StartServer();
        clientManager.StartClient();
        yield return new WaitForSeconds(3f);
        gameManager.PlaceCard(0, 0, true); // Красная карта
        gameManager.PlaceCard(1, 0, false); // Желтая карта
        player.TakeTurn(true);
        player.CastServerRpc(0);
        yield return new WaitForSeconds(1f);
        Assert.AreEqual(0, gameManager.playerCards[0, 1, 0], "Prep не очищен после каста!");
        Assert.AreEqual(0, gameManager.playerCards[0, 1, 1], "Prep не очищен после каста!");
    }

    [Test]
    public IEnumerator Test_TurnEnd()
    {
        serverObject = new GameObject("Server");
        serverManager = serverObject.AddComponent<NetworkManager>();
        gameManager = serverObject.AddComponent<GameManager>();
        serverManager.NetworkConfig = new NetworkConfig();
        
        GameObject client1Object = new GameObject("Client1");
        NetworkManager client1Manager = client1Object.AddComponent<NetworkManager>();
        Player player1 = client1Object.AddComponent<Player>();
        client1Manager.NetworkConfig = new NetworkConfig();
        
        GameObject client2Object = new GameObject("Client2");
        NetworkManager client2Manager = client2Object.AddComponent<NetworkManager>();
        Player player2 = client2Object.AddComponent<Player>();
        client2Manager.NetworkConfig = new NetworkConfig();

        // Временные префабы
        GameObject tempPlayerPrefab = new GameObject("TempPlayerPrefab");
        tempPlayerPrefab.AddComponent<Player>();
        tempPlayerPrefab.AddComponent<NetworkObject>();
        gameManager.playerPrefab = tempPlayerPrefab;

        serverManager.StartServer();
        client1Manager.StartClient();
        client2Manager.StartClient();
        yield return new WaitForSeconds(3f);
        player1.TakeTurn(true);
        player1.EndTurnServerRpc();
        yield return new WaitForSeconds(1f);
        Assert.AreEqual(1, gameManager.currentTurn, "Ход не перешел к следующему игроку!");
        Assert.IsTrue(player2.Turn, "Второй игрок не получил ход!");

        // Очистка
        NetworkManager.Singleton.Shutdown();
        Object.DestroyImmediate(serverObject);
        Object.DestroyImmediate(client1Object);
        Object.DestroyImmediate(client2Object);
    }
}