using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class NextDialogueMerchant : MonoBehaviour, IPointerClickHandler
{
    public GameObject box;
    public void OnPointerClick(PointerEventData eventData)
    {
        NPCDialogueTrigger script = box.GetComponent<NPCDialogueTrigger>();
        script.GoNext();
    }
}
