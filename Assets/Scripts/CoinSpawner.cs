using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(
                prefab, 
                transform.position + new Vector3(Random.Range(-2f, 2f), 0, 0), 
                Quaternion.identity);
        }
    }
}
