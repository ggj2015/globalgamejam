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

	public static int playerPScore;
	private Text scoreText;

	TeamScore enemyA;
	TeamScore enemyB;
	TeamScore enemyC;
	TeamScore enemyD;
	
	void Awake ()
	{
		//text = GetComponent<Text> ();
		scoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Text> ();

		scoreText.text = "";
		playerPScore = 0;
		// Set up the reference.
		//ScoreP = GetComponent ("ScoreP");
		//ScoreA = GetComponent ("ScoreA");


		//ScoreText = GetComponent <Text> ();
		
		// Reset the score.
		//score = 0;
	}
	
	void Update ()
	{

		scoreText.text = "Score: " + playerPScore;
		//text.text = "Score: " + playerPScore;

		//ScoreP.ScoreText = 1;

		// Set the displayed text to be the word "Score" followed by the score value.
		//Text ScoreP.ScoreText.text = Score + player.totalScore;
		//Text ScoreA.ScoreText.text = ;
		
	}
}
