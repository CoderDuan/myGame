using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Creature {

    public string name;
    public int health;
    public int mana;
    public int action;
    public int handSize;

    protected List<Card> originalDeck = new List<Card>();
    protected List<Card> deck = new List<Card>();
    protected List<Card> hand = new List<Card>();
    protected List<Card> table = new List<Card>();
    protected List<Card> discard = new List<Card>();

    // Use this for initialization
    public Creature (string nameString, int hp, int mp, int ap, int hs) {
        name = nameString;
        health = hp;
        mana = mp;
        action = ap;
        handSize = hs;
	}

    public bool TakeDamage(int damage, DamageTypes damageType)
    {
        if (damage > 0)
        {
            health -= damage;
            return true;
        } else
        {
            return false;
        }
    }

    public void AddDeck(Card card)
    {
        originalDeck.Add(card);
    }

    public void AddDeck(string cardName)
    {
        if (DeckOfAll.getInstance().cards.ContainsKey(cardName))
            originalDeck.Add(DeckOfAll.instance.cards[cardName]);
    }

    public void AddDeckTemp(Card card)
    {
        deck.Add(card);
    }

    public void AddDeckTemp(string cardName)
    {
        if (DeckOfAll.getInstance().cards.ContainsKey(cardName))
            deck.Add(DeckOfAll.instance.cards[cardName]);
    }

    public void AddHand(Card card)
    {
        hand.Add(card);
    }

    public void AddHand(string cardName)
    {
        if (DeckOfAll.getInstance().cards.ContainsKey(cardName))
            hand.Add(DeckOfAll.instance.cards[cardName]);
    }

    public void AddTable(Card card)
    {
        table.Add(card);
    }

    public void AddTable(string cardName)
    {
        if (DeckOfAll.getInstance().cards.ContainsKey(cardName))
            table.Add(DeckOfAll.instance.cards[cardName]);
    }

    public void AddDiscard(Card card)
    {
        table.Add(card);
    }

    public void AddDiscard(string cardName)
    {
        if (DeckOfAll.getInstance().cards.ContainsKey(cardName))
            table.Add(DeckOfAll.instance.cards[cardName]);
    }

    public void CreateDeckTemp()
    {
        deck.Clear();
        deck = new List<Card>(originalDeck);
    }

    public void DrawHand()
    {
        while (hand.Count < handSize)
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        if (deck.Count + discard.Count == 0)
            return;
        if (deck.Count == 0)
            RecycleDiscard();
        int id = deck.Count - 1; // last card
        Card c = deck[id];
        hand.Add(c);
        deck.RemoveAt(id);
    }

    private void RecycleDiscard()
    {
        if (deck.Count == 0)
        {
            deck = new List<Card>(discard);
            discard.Clear();
            Shuffle();
        }
    }

    private void Shuffle()
    {
        
        for (int i = 0; i < deck.Count; i++)
        {
            // swap i-th and j-th card
            int j = Random.Range(i, deck.Count);
            Card c = deck[j];
            deck[j] = deck[i];
            deck[i] = c;
        }
    }
}
