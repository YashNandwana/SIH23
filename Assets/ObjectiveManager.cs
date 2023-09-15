using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static ObjectiveManager instance { get; private set; }

    public bool coin = false;
    public bool bought = false;

    public GameObject open, closed, priest;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;
    }

    public void OpenDoor()
    {
        closed.SetActive(false);
        open.SetActive(true);
    }

    public void SetPriestFlag()
    {
        priest.GetComponent<NPCDialogueTrigger>().flag = true;
    }
}
