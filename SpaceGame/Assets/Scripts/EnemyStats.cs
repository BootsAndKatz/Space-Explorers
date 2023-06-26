using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int health = 100;
    int currentHealth;


    private void Start()
    {
        currentHealth = health;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
        Debug.Log("Enemy hit");
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
