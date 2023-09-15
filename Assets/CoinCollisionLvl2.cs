using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollisionLvl2 : MonoBehaviour
{
    public GameObject NPC;
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
        ObjectiveManagerLvl2.instance.coin = true;
        NPC.GetComponent<NPCTrigger>().flag = true;
    }
}
