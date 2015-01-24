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
	private Text scoreText, devScoreText, graphicsScoreText, audioScoreText;

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
		devScoreText = GameObject.FindGameObjectWithTag ("DevScoreText").GetComponent<Text> ();
		graphicsScoreText = GameObject.FindGameObjectWithTag ("GraphicsScoreText").GetComponent<Text> ();
		audioScoreText = GameObject.FindGameObjectWithTag ("AudioScoreText").GetComponent<Text> ();

		scoreText.text = "";
		playerPScore = 0;

		devScoreText.text = "";
		audioScoreText.text = "";
		graphicsScoreText.text = "";

		// Set up the reference.
		//ScoreP = GetComponent ("ScoreP");
		//ScoreA = GetComponent ("ScoreA");
	
		//ScoreText = GetComponent <Text> ();
	}
	void FixedUpdate() {
		scoreText.text = "Score: " + playerPScore;
		playerPScore = playerPScore + 3;

		devScoreText.text = "Dev: " + playerPScore;
		playerPScore = playerPScore + 9; //temp

		audioScoreText.text = "Audio: " + playerPScore;
		playerPScore = playerPScore + 10; //temp

		graphicsScoreText.text = "Graphics: " + playerPScore;
		playerPScore = playerPScore + 15; //temp

	}
}
