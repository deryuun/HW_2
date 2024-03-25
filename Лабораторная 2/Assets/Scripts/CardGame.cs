using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    private int _offset = 1;
    private static CardGame _cardInstance;
    public Dictionary<CardInstance, CardView> _cardDictionary = new Dictionary<CardInstance, CardView>();
    public List<CardAsset> cardAssets;

    private CardGame()
    {
        cardAssets = new List<CardAsset>();
    }
    void Awake()
    {
        if (cardAssets != null)
        {
            Debug.Log("Error");
        }
        _cardInstance = this;
        StartGame();
    }

    public static CardGame GetInstance()
    {
        return _cardInstance;
    }

    public void StartGame()
    {
        foreach (CardAsset asset in cardAssets)
        {
            CreateCard(asset, 0);
        }
    }

    public void CreateCardView(CardInstance cardInstance)
    {
        GameObject prefab = null;
        prefab = Instantiate(cardInstance.GetCardAsset().GetCardPrefab());

        prefab.AddComponent<CardView>();
        CardView cardView = prefab.GetComponent<CardView>();

        cardView.Init(cardInstance);
        _cardDictionary.Add(cardInstance, cardView);
    }

    public void CreateCard(CardAsset cardAsset, int layoutId)
    {
        var cardInstance = new CardInstance(cardAsset);
        cardInstance.CardPosition = _offset;
        ++_offset;
        CreateCardView(cardInstance);
        cardInstance.MoveToLayout(layoutId);
    }
    
    public List<CardInstance> GetCardsInLayout(int layoutId)
    {
        var cardsInLayout = new List<CardInstance>();
        foreach (var cardInstance in _cardDictionary.Keys)
        {
            if (cardInstance.LayoutId == layoutId)
            {
                cardsInLayout.Add(cardInstance);
            }
        }
        return cardsInLayout;
    }
}
