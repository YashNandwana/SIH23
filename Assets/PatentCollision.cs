using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatentCollision : MonoBehaviour
{
    public int patentNumber;
    public void OnTriggerEnter2D()
    {
        Debug.Log("in");
        ObjectiveManagerLvl3.instance.patent[patentNumber] = true;
        transform.gameObject.SetActive(false);
    }
}
