using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int index;

    public TextMeshProUGUI keyCount;

    void OnCollisionEnter2D()
    {
        if (ObjectiveManagerLvl3.instance.key[index] > 0)
        {
            ObjectiveManagerLvl3.instance.key[index] -= 1;
            int val = ObjectiveManagerLvl3.instance.key[index];
            keyCount.SetText(val.ToString());
            GetComponent<SpriteRenderer>().enabled = GetComponent<BoxCollider2D>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
