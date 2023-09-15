using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatentCollision : MonoBehaviour
{
    public int patentNumber;
    public void OnCollisionEnter2D()
    {
        ObjectiveManagerLvl3.instance.patent[patentNumber] = true;
        transform.gameObject.SetActive(false);
    }
}
