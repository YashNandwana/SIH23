using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class DialogueBoxClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject gameobject;
    public void OnPointerClick(PointerEventData eventData)
    {
        gameobject.SetActive(false);
    }
}
