using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManagerLvl2 : MonoBehaviour
{
    public static ObjectiveManagerLvl2 instance { get; private set; }

    public int rune = 0;
    public bool coin = false;

    public GameObject soldier, exitCollider, nextScene;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }

    public int increment()
    {
        rune++;
        return rune;
    }

    public void RemoveColliders()
    {
        exitCollider.SetActive(false);
        nextScene.SetActive(true);
    }
}
