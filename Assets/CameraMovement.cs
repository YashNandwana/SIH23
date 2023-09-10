using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject follow;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dest = follow.transform.position;
        transform.position = new Vector3(dest.x, dest.y, transform.position.z);
    }
}
