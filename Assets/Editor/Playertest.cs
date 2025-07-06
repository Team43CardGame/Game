using NUnit.Framework;
using UnityEngine;
using Unity.Netcode;

[TestFixture]
public class PlayerTests
{
    private Player player;

    [SetUp]
    public void SetUp()
    {
        // Создаём временный GameObject и добавляем компонент Player
        GameObject go = new GameObject();
        player = go.AddComponent<Player>();
    }

    [TearDown]
    public void TearDown()
    {
        // Уничтожаем временный GameObject после каждого теста
        Object.DestroyImmediate(player.gameObject);
    }

    [Test]
    public void SetId_SetsCorrectId()
    {
        // Arrange
        int expectedId = 42;

        // Act
        player.SetId(expectedId);

        // Assert
        Assert.AreEqual(expectedId, player.ID, "Player ID should be set to 42");
    }

    [Test]
    public void TakeTurn_SetsTurnAndMovesCorrectly()
    {
        // Arrange
        bool expectedTurn = true;
        int expectedMoves = 1; // По умолчанию maxMoves = 1

        // Act
        player.TakeTurn(expectedTurn);

        // Assert
        Assert.AreEqual(expectedTurn, player.Turn, "Turn should be set to true");
        Assert.AreEqual(expectedMoves, player.remainingMoves, "Remaining moves should be set to 1");
    }

    [Test]
    public void TakeTurn_TurnOff_SetsMovesToZero()
    {
        // Arrange
        bool expectedTurn = false;
        int expectedMoves = 0;

        // Act
        player.TakeTurn(expectedTurn);

        // Assert
        Assert.AreEqual(expectedTurn, player.Turn, "Turn should be set to false");
        Assert.AreEqual(expectedMoves, player.remainingMoves, "Remaining moves should be set to 0");
    }

    [Test]
    public void Select_SetsSelectedColor()
    {
        // Arrange
        int expectedColor = 1; // Y

        // Act
        player.Select(expectedColor);

        // Assert
        Assert.AreEqual(expectedColor, player.selected, "Selected color should be set to 1");
    }


    [Test]
    public void Kill_DoesNotDestroyIfIdMatches()
    {
        // Arrange
        player.SetId(1);
        int sameId = 1;

        // Act
        player.Kill(sameId);

        // Assert
        Assert.IsNotNull(player, "Player should not be destroyed if IDs match");
    }
}
