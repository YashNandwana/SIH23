using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class BookTrigger : MonoBehaviour, IPointerClickHandler
{
    public GameObject book;
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject bookIcon = eventData.pointerCurrentRaycast.gameObject;
        book.SetActive(true);
        bookIcon.SetActive(false);
    }
}
