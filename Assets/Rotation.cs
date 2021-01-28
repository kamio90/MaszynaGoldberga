using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotateSpeed;
    void Update () {
        rotate();
    }
 
 
    void rotate() {
        transform.Rotate(Vector3.one, rotateSpeed * Time.deltaTime, Space.World);
    }
}
