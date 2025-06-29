using NUnit.Framework;
using UnityEngine;

public class PlayerEditModeTests
{
    private Player player;
    private GameObject playerGO;

    [SetUp]
    public void Setup()
    {

        playerGO = new GameObject("Player");
        player = playerGO.AddComponent<Player>();
    }

    [TearDown]
    public void Teardown()
    {

        Object.DestroyImmediate(playerGO);
    }

    [Test]
    public void SetId_CorrectlySetsPlayerId()
    {

        int expectedId = 5;


        player.SetId(expectedId);

        Assert.AreEqual(expectedId, player.ID, "ID игрока должен быть равен установленному значению");
    }


    [Test]
public void Receive_CorrectlyUpdatesHandCards()
{
  
    int[] testCards = { 5, 3, 2 }; 

    var handGO = new GameObject("Hand");
    var realHand = handGO.AddComponent<HandScript>();
    
    
    player.handScript = realHand;
    player.deckPrefab = new GameObject("DeckPrefab"); 
    player.deckPrefab.AddComponent<CardDeckScript>(); 

   
    player.Receive(testCards);


    Assert.AreEqual(testCards, player.handCards, "Массив карт в Player должен обновиться");
    Assert.AreEqual(testCards, realHand.remainingCards, "Массив remainingCards в HandScript должен обновиться");
}
    
}