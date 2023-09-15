using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManagerLvl3 : MonoBehaviour
{
    public static ObjectiveManagerLvl3 instance { get; private set; }

    public int[] key = new int[3];
    public bool[] patent = new bool[3];

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }


}
