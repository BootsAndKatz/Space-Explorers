using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform shootPos;
    public int damage = 50;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RaycastHit hit;
            if (Physics.Raycast(shootPos.position, Vector3.forward, out hit, 20))
            {
                Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
                Debug.DrawLine(shootPos.position, shootPos.position + new Vector3(0, 0, 20), Color.red, 0.2f);

                hit.collider.GetComponent<EnemyStats>().TakeDamage(damage);
            }

        }
    }
}
