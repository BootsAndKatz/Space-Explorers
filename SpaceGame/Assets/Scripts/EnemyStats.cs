using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int health = 100;
    public healthBar healthBar;

    int currentHealth;
    GameObject manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager");
        currentHealth = health;
        healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }

        //Debug.Log("Enemy hit");
    }

    //destroys the object this script is attacched to and adds to the score
    void Die()
    {
        manager.GetComponent<ScoreScript>().AddScore(10);
        Destroy(this.gameObject);
    }

    
}
