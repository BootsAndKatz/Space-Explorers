using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    //in front of the player
    public Transform shootPos;
    public GameObject laser;
    public GameObject damageNumberPrefab;

    public int damage = 50;

    public float delay;
    public float damageNumberOffSet;


    MeshRenderer mrLaser;
    // time until player can shoot agains and how long the laser is shown on screen
    float next;
    bool canShoot = true;

    void Start()
    {
        mrLaser = laser.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //check for shooting delay and laser visibility
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

                //All enemies should have an Enemy stats script atached

                if(hit.collider.GetComponent<EnemyStats>() != null)
                {
                hit.collider.GetComponent<EnemyStats>().TakeDamage(damage);
                }

                ShowDamageNumber(damage,hit.transform);

            }

            canShoot = false;
            mrLaser.enabled = true;
            next = Time.time + delay;
        }
    }

    //spawns a prefab of a number. Method takes amount of damage to be shown and the enemy transform to use their position
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
