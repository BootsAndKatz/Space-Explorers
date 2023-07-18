using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFieldScript : MonoBehaviour
{

    public float width = 2;
    public float height = 1;
    public float length = 20;
    public float density = 1;

    public GameObject asteroid;

    Vector3 playerPos;
    public Vector3 fieldOffset = new Vector3(7,0,0);
    // Start is called before the first frame update
    void Start()
    {
        GenerateInitialField(width, height, length, density, fieldOffset);

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }


    void GenerateInitialField(float width, float height, float depth, float density, Vector3 offSet)
    {
        //right field
        for(int i = 0; i < density; i++)
        {
            Vector3 position = new Vector3(Random.Range(-width / 2, width/2), Random.Range(-height / 2, height/2), Random.Range(-depth / 2, depth / 2)) + offSet;
            Instantiate(asteroid, position, Quaternion.identity);
        }
        //left field
        for (int i = 0; i < density; i++)
        {
            Vector3 position = new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-height / 2, height / 2), Random.Range(-depth / 2, depth / 2)) + offSet;
            position.x = -position.x;
            Instantiate(asteroid, position, Quaternion.identity);
        }
    }

    void GenerateAsteroids()
    {

    }

    
}
