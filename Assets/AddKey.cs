using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AddKey : MonoBehaviour, IPointerClickHandler
{
    private float startTime, curTime;
    public TextMeshProUGUI textBox;
    public int keyNum = -1;
    public GameObject fadeObject;
    private bool flag = false;
    public void OnPointerClick(PointerEventData data)
    {
        if (ObjectiveManagerLvl3.instance.patent[keyNum])
        {
            ObjectiveManagerLvl3.instance.key[keyNum]++;
            int val = ObjectiveManagerLvl3.instance.key[keyNum];
            textBox.SetText(val.ToString());
        }
        else
            flag = true;
    }

    void Update()
    {
        if (flag)
        {
            CanvasGroup cg = fadeObject.GetComponent<CanvasGroup>();
            curTime = Time.time;
            cg.alpha += (curTime - startTime) * 0.01f;

            if (cg.alpha >= 0.99)
                SceneManager.LoadScene(1);
        }
    }
}
