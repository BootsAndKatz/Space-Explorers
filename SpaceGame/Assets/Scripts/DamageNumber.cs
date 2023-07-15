using TMPro;
using UnityEngine;

public class DamageNumber : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float numberLifeTime = 1f;
    public TextMeshPro damageText;

    private void Start()
    {
        Destroy(gameObject, numberLifeTime); // Destroy the damage number after 2 seconds
    }

    private void Update()
    {
        // Move the damage number upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        //transform.LookAt(GameObject.FindGameObjectWithTag("MainCamera").transform);

    }

    public void SetDamageNumber(int damage)
    {
        damageText.text = damage.ToString();
    }
}
