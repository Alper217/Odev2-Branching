using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float rotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(rotationSpeed*Time.deltaTime, rotationSpeed * Time.deltaTime, 0f);
    }
}
