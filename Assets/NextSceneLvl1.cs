using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLvl1 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(2);
    }
}
