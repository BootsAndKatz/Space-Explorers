using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform shootPos;
    public int damage = 50;
    public GameObject laser;
    MeshRenderer mrLaser;
    float next;
    public float delay;
    bool canShoot = true;
    public GameObject damageNumberPrefab;
    public float damageNumberOffSet;

    void Start()
    {
        mrLaser = laser.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > next)
        {
            mrLaser.enabled = false;
            canShoot = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && canShoot)
        {
            //Debug.Log("Shot!");

            RaycastHit hit;
            if (Physics.Raycast(shootPos.position, Vector3.forward, out hit, 20))
            {
                //Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
                //Debug.DrawLine(shootPos.position, shootPos.position + new Vector3(0, 0, 20), Color.red, 0.2f);
                

                hit.collider.GetComponent<EnemyStats>().TakeDamage(damage);

                ShowDamageNumber(damage,hit.transform);

            }

            canShoot = false;
            mrLaser.enabled = true;
            next = Time.time + delay;
        }
    }

    public void ShowDamageNumber(int damage, Transform enemy)
    {
        Vector3 offSet = new Vector3(Random.Range(-1f, 1f), damageNumberOffSet, 0);
        GameObject damageNumberObject = Instantiate(damageNumberPrefab, enemy.position + offSet, Quaternion.identity);
        DamageNumber damageNumber = damageNumberObject.GetComponent<DamageNumber>();

        if (damageNumber != null)
        {
            damageNumber.SetDamageNumber(damage);
        }
        else
        {
            Debug.LogWarning("DamageNumber component not found on the instantiated object.");
        }
    }

}
