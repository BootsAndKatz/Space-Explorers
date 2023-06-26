using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 2.5f;
   
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
