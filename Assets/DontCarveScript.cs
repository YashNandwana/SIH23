using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DontCarveScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject parent;
    public void OnPointerClick(PointerEventData eventData)
    {
        parent.SetActive(false);
    }

}
