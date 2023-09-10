using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGizmo : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, Vector2.one);
    }
}
