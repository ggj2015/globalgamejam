using UnityEngine;
using System.Collections;

public class ScoreCache : MonoBehaviour {
    static GameObject score0;
    static GameObject score1;
    static GameObject score2;
    static GameObject score3;
    static GameObject score4;
    static GameObject score5;

    void Start() {
        score0 = GameObject.Find("Score0");
        score1 = GameObject.Find("Score1");
        if (score0) {
            Debug.Log("Score0 object found");
        } else {
            Debug.Log("WHAT THE FUCK?>:");
        }
    }

    void Update() {

    }

    public static ScoreManager getScoreManager(int n) {
        // Get the team table it's colliding with and add to its score
        switch (n) {
            case 0:
                return score0.GetComponent<ScoreManager>();
            default:
                return null;
        }
    }

}
