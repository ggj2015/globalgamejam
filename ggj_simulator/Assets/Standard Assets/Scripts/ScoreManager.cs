using UnityEngine;
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
    private Slider devSlider, graphicsSlider, audioSlider;

	private float currentScore;
	public float currentDevScore, currentGraphicsScore, currentAudioScore;

	public float currentDevScoreRate, currentGraphicsScoreRate, currentAudioScoreRate;

	void Awake ()
	{
		totalScoreText = transform.Find("ScoreText").GetComponent<Text> ();
		devScoreText = transform.Find("DevScoreText").GetComponent<Text> ();
		graphicsScoreText = transform.Find("GraphicsScoreText").GetComponent<Text> ();
		audioScoreText = transform.Find("AudioScoreText").GetComponent<Text> ();

        devSlider = transform.Find("DevSlider").GetComponent<Slider>();
        graphicsSlider = transform.Find("GraphicsSlider").GetComponent<Slider>();
        audioSlider = transform.Find("AudioSlider").GetComponent<Slider>();

		totalScore = 0;
		totalScoreText.text = devScoreText.text = audioScoreText.text = graphicsScoreText.text = "";

        devSlider.value = graphicsSlider.value = audioSlider.value = 0;

		//temp
		currentDevScoreRate = 0; 
		currentGraphicsScoreRate = 0; 
		currentAudioScoreRate = 0; 
	}
     
    void Start() {

    }
	
	// change this to per sec
	void FixedUpdate() {

		devScoreText.text = "Dev: " + currentDevScore;
		currentDevScore = currentDevScore + currentDevScoreRate; //temp
        devSlider.value = currentDevScore;
		
		graphicsScoreText.text = "Graphics: " + currentGraphicsScore;
		currentGraphicsScore = currentGraphicsScore + currentGraphicsScoreRate; //temp
        graphicsSlider.value = currentGraphicsScore;
		
		audioScoreText.text = "Audio: " + currentAudioScore;
		currentAudioScore = currentAudioScore + currentAudioScoreRate; //temp
        audioSlider.value = currentAudioScore;
		
        getTotalScore ();
	}

	void getTotalScore() {
		float lowestScore = System.Math.Min(currentDevScore, System.Math.Min(currentGraphicsScore, currentAudioScore));
		totalScoreText.text = gameObject.transform.name + ":" + lowestScore;	
	}

	public void updateDevScoreRate(float deltaScore) {
		currentDevScoreRate += deltaScore;
        Debug.Log(deltaScore);
	}

	public void updateGraphicsScoreRate(float deltaScore) {
		currentGraphicsScoreRate += deltaScore;
	}

	public void updateAudioScoreRate(float deltaScore) {
		currentDevScoreRate += deltaScore;
	}

}
