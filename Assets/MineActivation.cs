using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineActivation : MonoBehaviour
{
    public GameObject respawnPoint;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.transform.position = respawnPoint.transform.position;
    }
}
