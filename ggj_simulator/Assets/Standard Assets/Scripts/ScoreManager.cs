﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

//struct TeamScore {
//	int totalScore;
//	int developer;
//	int audio;
//	int graphics;
//}

public class ScoreManager : MonoBehaviour {

	public static float totalScore;
	private Text totalScoreText, devScoreText, graphicsScoreText, audioScoreText;

	private float currentScore;
	public float currentDevScore, currentGraphicsScore, currentAudioScore;

	public float currentDevScoreRate, currentGraphicsScoreRate, currentAudioScoreRate;

	void Awake ()
	{
		totalScoreText = transform.Find("ScoreText").GetComponent<Text> ();
		devScoreText = transform.Find("DevScoreText").GetComponent<Text> ();
		graphicsScoreText = transform.Find("GraphicsScoreText").GetComponent<Text> ();
		audioScoreText = transform.Find("AudioScoreText").GetComponent<Text> ();

		totalScore = 0;
		totalScoreText.text = devScoreText.text = audioScoreText.text = graphicsScoreText.text = "";

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
		float lowestScore = System.Math.Min(currentDevScore, System.Math.Min(currentGraphicsScore, currentAudioScore));
		totalScoreText.text = "Score: " + lowestScore;
	}

	public void updateDevScoreRate(float deltaScore) {
		currentDevScoreRate += deltaScore;
	}

	public void updateGraphicsScoreRate(float deltaScore) {
		currentGraphicsScoreRate += deltaScore;
	}

	public void updateAudioScoreRate(float deltaScore) {
		currentDevScoreRate += deltaScore;
	}

}
