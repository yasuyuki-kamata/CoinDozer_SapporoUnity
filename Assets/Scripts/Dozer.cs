using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dozer : MonoBehaviour
{

    private Rigidbody rigidbody;
    private Vector3 firstPosition;
    public float speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        firstPosition = transform.position;
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(
            firstPosition + 
            new Vector3(0, 0, Mathf.Sin(Time.time * speed))
            );
    }
}
