using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int index;

    void OnCollisionEnter2D()
    {
        if (ObjectiveManagerLvl3.instance.key[index] > 0)
        {
            ObjectiveManagerLvl3.instance.key[index] -= 1;
            GetComponent<SpriteRenderer>().enabled = GetComponent<BoxCollider2D>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
