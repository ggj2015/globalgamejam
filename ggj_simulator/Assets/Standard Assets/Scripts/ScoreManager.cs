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

	private float currentScore;
	private float currentScoreRate;

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
	}
	void FixedUpdate() {
		scoreText.text = "Score: " + playerPScore;
		playerPScore = playerPScore + 3;
	}
}
