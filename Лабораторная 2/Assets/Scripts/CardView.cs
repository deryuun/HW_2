using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CardView : MonoBehaviour
{
    private CardInstance _cardInstance;

    public void Init(CardInstance instance)
    {
        _cardInstance = instance;
    }
    
    public void UpdatePosition(Vector3 vector3)
    {
        transform.position = vector3;
    }
    
    public void Rotate(bool faceUp)
    {
        
    }
}
