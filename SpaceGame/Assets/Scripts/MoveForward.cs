using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 2.5f;
   
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}