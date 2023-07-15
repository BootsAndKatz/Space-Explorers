using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRandomRotation : MonoBehaviour
{
    public float speed;
    private float rotationSpeed;
    private Vector3 rotationAxis;

    private void Start()
    {
        // Generate random rotation speed between 0.5 and 2 units per second
        rotationSpeed = Random.Range(0.5f, 2f);

        // Generate random rotation axis
        rotationAxis = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    private void Update()
    {
        // Rotate the object around the random axis at the random speed
        transform.Rotate(rotationAxis, rotationSpeed * speed * Time.deltaTime);
    }
}
