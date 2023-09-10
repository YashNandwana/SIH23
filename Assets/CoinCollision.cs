using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
        ObjectiveManager.instance.coin = true;
        Debug.Log(ObjectiveManager.instance.coin);
    }
}
