using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecontroller : MonoBehaviour
{
    public static int score;
    public Text textscore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textscore = GameObject.Find("score").GetComponent<Text>();
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
            score++;
            textscore.text = score.ToString();
        }
        
    }

}
