using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove1 : MonoBehaviour
{
    Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        ball.AddForce(new Vector3(1, 0, 1).normalized * 500f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
