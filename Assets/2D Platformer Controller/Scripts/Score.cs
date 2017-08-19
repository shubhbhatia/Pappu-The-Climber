using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    int points;
    public Text scoreText;
    int totalBananasAtStart = 0;
    public GameObject Bananas;


	// Use this for initialization
	void Start () {

        points = 0;
        totalBananasAtStart = Bananas.transform.childCount;
    }
	
	// Update is called once per frame
	void Update () {
        int bananasLeft = Bananas.transform.childCount;
        int bananaBonus = totalBananasAtStart - bananasLeft;

        points = bananaBonus * 10;  //Maybe change this....

        scoreText.text = "Score " + points;
        
	}

    public void IncreaseScore(int p)
    {
        points += p;
    }
}
