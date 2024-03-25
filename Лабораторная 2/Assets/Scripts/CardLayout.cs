using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLayout : MonoBehaviour
{
    public int layoutId;
    public Vector3 offsеt;
    private bool faceUp;

    private void Update()
    {
        var cardsInLayout = CardGame.GetInstance().GetCardsInLayout(layoutId);

        foreach (var card in cardsInLayout)
        {
            CardGame.GetInstance()._cardDictionary[card].transform.SetParent(transform);
            CardGame.GetInstance()._cardDictionary[card].UpdatePosition(transform.position + (card.CardPosition * offsеt));
            CardGame.GetInstance()._cardDictionary[card].Rotate(faceUp);
        }
    }
}
