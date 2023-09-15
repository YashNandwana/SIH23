using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class NextDialogueLvl2 : MonoBehaviour, IPointerClickHandler
{
    public GameObject NPC;
    public void OnPointerClick(PointerEventData eventData)
    {
        NPCTrigger script = NPC.GetComponent<NPCTrigger>();
        script.GoNext();
    }
}
