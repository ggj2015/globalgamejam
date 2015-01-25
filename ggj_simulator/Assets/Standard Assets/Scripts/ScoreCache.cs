using UnityEngine;
using System.Collections;

public class ScoreCache : MonoBehaviour {
    static GameObject score0;
    static GameObject score1;
    static GameObject score2;
    static GameObject score3;
    static GameObject score4;
    static GameObject score5;

    void Awake() {
        score0 = GameObject.Find("Score0");
        score1 = GameObject.Find("Score1");
        score2 = GameObject.Find("Score2");
        score3 = GameObject.Find("Score3");
        score4 = GameObject.Find("Score4");
        score5 = GameObject.Find("Score5");
    }

    void Start() {
    }

    void Update() {

    }

    public static ScoreManager getScoreManager(int n) {
        // Get the team table it's colliding with and add to its score
        switch (n) {
            case 0:
                return score0.GetComponent<ScoreManager>();
            case 1:
                return score1.GetComponent<ScoreManager>();
            case 2:
                return score2.GetComponent<ScoreManager>();
            case 3:
                return score3.GetComponent<ScoreManager>();
            case 4:
                return score4.GetComponent<ScoreManager>();
            case 5:
                return score5.GetComponent<ScoreManager>();
            default:
                return null;
        }
    }

}
