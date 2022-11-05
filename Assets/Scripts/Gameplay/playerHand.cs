using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class playerHand : MonoBehaviour
{
    //Player hand
    public List<Card> hand;

    public Deck deck;

    public UnityEvent playCard;

    // Start is called before the first frame update
    private void Start()
    {
        //get deck component to make life easier
        deck = GameObject.FindObjectOfType<Deck>();

    }

    //can only use major arcana
    public void useCard(Card card)
    {
        if (card.isMinor == false) 
        {
            //Do a thing
        }

    }

    //get rid of card, add to discard deck
    public void discardCard(Card card)
    {
        hand.Remove(card);
        deck.discardPile.Add(card);
    }
    
    //get minor arcana card
    public Card[] getMinor()
    {
        List<Card> minorArcana = new List<Card>();
        for (int i = 0; i < hand.Count; i++)
        {
            if (hand[i].isMinor)
            {
                minorArcana.Add(hand[i]);
            }
        }   

        return minorArcana.ToArray();
    }

    public void Reverse(MajorArcana card)
    {
        card.ReverseCard();
    }

    public void drawCardsFromDeck(int NumToDraw)
    {
        Card [] cards = deck.deal(NumToDraw);
        hand.AddRange(cards);
    }
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Drawing Cards...");
            drawCardsFromDeck(5);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Showing Cards in Hand...");
            foreach (var card in hand)
            {
                Debug.Log(card);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Reversing all cards in hand...");
                for(int i = 0; i < hand.Count; i++)
                {
                    hand[i] = Reverse(hand[i]);
                }
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Discard Cards...");
            int x = hand.Count; 
            for(int i = 0; i < x; i++)
            {
                //discard all algo
                discardCard(hand[x - (i + 1)]);

            }

            
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("Using All Cards...");
            int x = hand.Count;
            for (int i = 0; i < x; i++)
            {
               //use all algo
               useCard(hand[x - (i + 1)]);

            }


        }

    }
    */


}
