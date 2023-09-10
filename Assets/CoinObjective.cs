using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.Events;

public class CoinObjective : MonoBehaviour
{
    public UnityEvent onObjectiveMet;

    void OnTriggerEnter2D()
    {
        onObjectiveMet.Invoke();
    }
}
