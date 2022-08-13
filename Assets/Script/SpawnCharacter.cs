using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject obj;
    Vector3 spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(obj,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
