using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInstance 
{
    private CardAsset Asset { get;  }
    public int LayoutId { get; private set; }
    public int CardPosition { get; set; }

    public CardInstance(CardAsset asset)
    {
        Asset = asset;
    }

    public CardAsset GetCardAsset()
    {
        return Asset;
    }
    
    public void MoveToLayout(int newLayoutId)
    {
        LayoutId = newLayoutId;
    }
}
