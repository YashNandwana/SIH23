using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class CopyTrigger : MonoBehaviour, IPointerClickHandler
{
    private float startTime, curTime;
    public GameObject fadeObject;

    private bool flag = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        startTime = Time.time;
        flag = true;
    }

    void Update()
    {
        if (flag)
        {
            CanvasGroup cg = fadeObject.GetComponent<CanvasGroup>();
            curTime = Time.time;
            cg.alpha += (curTime - startTime) * 0.01f;
        }
    }
}
