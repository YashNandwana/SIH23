using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPopUp : MonoBehaviour
{
    public GameObject question;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        question.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        question.SetActive(false);
    }

}
