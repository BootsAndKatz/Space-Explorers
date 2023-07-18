using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int health;
    int currentHealth;
    public TextMeshProUGUI count;
    void Start()
    {
        currentHealth = health;
        count.text = currentHealth.ToString();

    }

    void TakeDamage()
    {
        currentHealth--;
        count.text = currentHealth.ToString();
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

        Destroy(other.gameObject);

    }
}
