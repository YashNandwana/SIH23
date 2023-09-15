using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PreviousPage : MonoBehaviour, IPointerClickHandler
{
    public GameObject parent;
    public void OnPointerClick(PointerEventData eventData)
    {
        PageRender script = parent.GetComponent<PageRender>();

        int index = script.GetIndex();
        script.Deactivate(index);
        script.SetIndex(Mathf.Max(0, index - 1));
    }
}
