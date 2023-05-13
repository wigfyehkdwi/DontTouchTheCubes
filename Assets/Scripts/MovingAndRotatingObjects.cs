using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAndRotatingObjects : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
