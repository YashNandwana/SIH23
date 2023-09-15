using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public GameObject MerchantNPC;
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
        ObjectiveManager.instance.coin = true;
        MerchantNPC.GetComponent<NPCDialogueTrigger>().flag = true;
        Debug.Log(ObjectiveManager.instance.coin);
    }
}
