using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardAsset : ScriptableObject
{ 
    public Rank cardName;
    public Suit cardColor;
    public GameObject cardImage;
    public GameObject cardBackground;
    
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
    public enum Rank
    {
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six
    }

    public GameObject GetCardPrefab()
    {
        return cardImage;
    }
}
