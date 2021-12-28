using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubedestroy : MonoBehaviour
{
    public scorecontroller2 Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Scoremanager").GetComponent<scorecontroller2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            Destroy(gameObject);
            Score.addScore();
        }

    }
}
