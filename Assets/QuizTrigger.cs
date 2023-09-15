using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public GameObject question;
    void OnTriggerEnter2D(Collider2D collider)
    {
        question.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        question.SetActive(false);
    }
}
