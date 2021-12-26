using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove2 : MonoBehaviour
{
    Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        //ball.AddForce(new Vector3(1, 0, 1).normalized * 500f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ball.AddForce(new Vector3(0, 0, 1).normalized * 2f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ball.AddForce(new Vector3(-1, 0, 0).normalized * 2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ball.AddForce(new Vector3(0, 0, -1).normalized * 2f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ball.AddForce(new Vector3(1, 0, 0).normalized * 2f);
        }
    }
}
