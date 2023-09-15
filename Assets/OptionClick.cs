using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Xml;

public class OptionClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject correct, wrong;
    public GameObject current, stone;
    public GameObject coin;
    public bool isCorrect = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isCorrect)
        {
            correct.SetActive(true);
            int cur = ObjectiveManagerLvl2.instance.increment();
            stone.SetActive(false);

            if (cur == 5)
                coin.SetActive(true);
        }
        else
            wrong.SetActive(true);

        current.SetActive(false);

    }
}
