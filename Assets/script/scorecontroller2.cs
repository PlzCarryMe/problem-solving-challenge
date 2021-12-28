using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecontroller2 : MonoBehaviour
{
    public static int score;
    public Text textscore;
    public RandomSpawn currentcube;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textscore = GameObject.Find("score").GetComponent<Text>();
        currentcube = GameObject.Find("spawnpoint").GetComponent<RandomSpawn>();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score++;
        textscore.text = score.ToString();
        currentcube.decreasecube();
    }

}
