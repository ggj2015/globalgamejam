using UnityEngine;
using UnityEngine.UI;
using System.Collections;

struct TeamScore {
	int totalScore;
	int developer;
	int audio;
	int graphics;
}

public class ScoreManager : MonoBehaviour {

	TeamScore player;
	TeamScore enemyA;
	TeamScore enemyB;
	TeamScore enemyC;
	TeamScore enemyD;

	void Awake ()
    {
        // Set up the reference.
 //       ScoreText = GetComponent <Text> ();

        // Reset the score.
        //player.totalScore = 0;
    }

    void Update ()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        //Text .ScoreText.text = Score + player.totalScore;
		//Text ScoreA.ScoreText.text = ;
    
    }
}
