using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 20f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("Move Left");
            rb.AddForce(Vector3.left * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("Move Right");
            rb.AddForce(Vector3.right * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
