using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankRuneTrigger : MonoBehaviour
{
    public GameObject blankRune;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        blankRune.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        blankRune.SetActive(false);
    }
}
