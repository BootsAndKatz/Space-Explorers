using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf1Second : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 1);
    }
     
    
}
