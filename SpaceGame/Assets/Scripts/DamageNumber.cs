using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DamageNumber : MonoBehaviour
{
    public float moveSpeed = 1f;

    public TextMeshPro damageText;

    private void Start()
    {
        Destroy(gameObject, 2f); // Destroy the damage number after 2 seconds
    }

    private void Update()
    {
        // Move the damage number upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

    }

    public void SetDamageNumber(int damage)
    {
        damageText.text = damage.ToString();
    }
}
