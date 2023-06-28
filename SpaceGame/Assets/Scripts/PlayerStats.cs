using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    int health = 3;
    int currentHealth;
    void Start()
    {
        currentHealth = health;
    }

    void TakeDamage()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    void Heal()
    {
        currentHealth++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Alien"))
        {
            TakeDamage();
            Debug.Log("PLayer HIT!");
        }

        if (other.gameObject.CompareTag("Asteroid"))
        {
            TakeDamage();
            Debug.Log("PLayer HIT!");
        }

    }
}
