using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class CloseBook : MonoBehaviour, IPointerClickHandler
{
    public GameObject book, bookIcon;
    public void OnPointerClick(PointerEventData eventData)
    {
        book.SetActive(false);
        bookIcon.SetActive(true);
    }
}
