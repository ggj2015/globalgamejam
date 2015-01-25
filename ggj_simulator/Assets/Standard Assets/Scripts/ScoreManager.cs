using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//struct TeamScore {
//	int totalScore;
//	int developer;
//	int audio;
//	int graphics;
//}

public class ScoreManager : MonoBehaviour {
	//TeamScore player;

	public static int playerPScore;
	private Text scoreText, devScoreText, graphicsScoreText, audioScoreText;

	private float currentScore;
	public float currentDevScore, currentGraphicsScore, currentAudioScore;

	public float currentDevScoreRate, currentGraphicsScoreRate, currentAudioScoreRate;

	void Awake ()
	{
		scoreText = transform.Find("ScoreText").GetComponent<Text> ();

		//gameObject.transform.name 
		//scoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Text> ();

//		devScoreText = GameObject.FindGameObjectWithTag ("DevScoreText").GetComponent<Text> ();
//		graphicsScoreText = GameObject.FindGameObjectWithTag ("GraphicsScoreText").GetComponent<Text> ();
//		audioScoreText = GameObject.FindGameObjectWithTag ("AudioScoreText").GetComponent<Text> ();
//
		devScoreText = transform.Find("DevScoreText").GetComponent<Text> ();
		graphicsScoreText = transform.Find("GraphicsScoreText").GetComponent<Text> ();
		audioScoreText = transform.Find("AudioScoreText").GetComponent<Text> ();

		scoreText.text = "";
		devScoreText.text = "";
		audioScoreText.text = "";
		graphicsScoreText.text = "";

		playerPScore = 0;

		//temp
		currentDevScoreRate = 1; 
		currentGraphicsScoreRate = 2; 
		currentAudioScoreRate = 3; 
	}
	
	// change this to per sec
	void FixedUpdate() {
		devScoreText.text = "Dev: " + currentDevScore;
		currentDevScore = currentDevScore + currentDevScoreRate; //temp
		
		graphicsScoreText.text = "Graphics: " + currentGraphicsScore;
		currentGraphicsScore = currentGraphicsScore + currentGraphicsScoreRate; //temp
		
		audioScoreText.text = "Audio: " + currentAudioScore;
		currentAudioScore = currentAudioScore + currentAudioScoreRate; //temp

		getTotalScore ();
	}

	void getTotalScore() {
		float lowestScore = currentDevScore; 
		scoreText.text = "Your Score: " + lowestScore;
	}

	public void updateDevScoreRate(int deltaScore) {
		currentDevScoreRate += deltaScore;
	}

	public void updateGraphicsScoreRate(int deltaScore) {
		currentGraphicsScoreRate += deltaScore;
	}

	public void updateAudioScoreRate(int deltaScore) {
		currentDevScoreRate += deltaScore;
	}

}
