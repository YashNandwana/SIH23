using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineGizmo : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, Vector2.one);
    }
}
