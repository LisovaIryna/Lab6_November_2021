using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        Vector3 p = player.transform.position;
        p.y = transform.position.y;
        p.z = transform.position.z;
        transform.position = p;
    }
}