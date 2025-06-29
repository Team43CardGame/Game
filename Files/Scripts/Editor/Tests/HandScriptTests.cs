using NUnit.Framework;
using UnityEngine;

public class HandScriptTests
{
    private HandScript hand;
    private GameObject handGO;

    [SetUp]
    public void Setup()
    {
        handGO = new GameObject("Hand");
        hand = handGO.AddComponent<HandScript>();
        hand.deckPrefab = new GameObject("DeckPrefab");
        hand.deckPrefab.AddComponent<CardDeckScript>();
    }

    [Test]
    public void ReceiveCardsInHand_InitializesAndUpdatesCards()
    {
        
        int[] testCards = { 2, 4, 1 };

        
        hand.ReceiveCardsInHand(testCards);

        
        Assert.AreEqual(testCards, hand.remainingCards);
        Assert.IsTrue(hand.initialized);
    }
}