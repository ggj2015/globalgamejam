using UnityEngine;
using System.Collections;

public class GgjObject : MonoBehaviour {
    protected float graphicsValue;
    protected float audioValue;
    protected float codeValue;


    void Awake () {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other) {
        // Only highlight if in the player's table area
        string tableName = other.transform.parent.gameObject.ToString();

        if (tableName == "Table 0 (UnityEngine.GameObject)") { // HACK needs to change if table name changes
            (gameObject.GetComponent("Halo") as Behaviour).enabled = true;
        }

        // Get the team table it's colliding with and add to its score
        switch (tableName) {
            case "Table 0 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(0).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(0).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(0).updateAudioScoreRate(audioValue);
                break;
            case "Table 1 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(1).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(1).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(1).updateAudioScoreRate(audioValue);
                break;
            case "Table 2 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(2).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(2).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(2).updateAudioScoreRate(audioValue);
                break;
            case "Table 3 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(3).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(3).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(3).updateAudioScoreRate(audioValue);
                break;
            case "Table 4 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(4).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(4).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(4).updateAudioScoreRate(audioValue);
                break;
            case "Table 5 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(5).updateDevScoreRate(codeValue);
                ScoreCache.getScoreManager(5).updateGraphicsScoreRate(graphicsValue);
                ScoreCache.getScoreManager(0).updateAudioScoreRate(audioValue);
                break;
            default:
                break;
        }
    }

    public void OnTriggerExit(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;

        string tableName = other.transform.parent.gameObject.ToString();

        switch (tableName) {
            case "Table 0 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(0).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(0).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(0).updateAudioScoreRate(-1 * audioValue);
                break;
            case "Table 1 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(1).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(1).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(1).updateAudioScoreRate(-1 * audioValue);
                break;
            case "Table 2 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(2).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(2).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(2).updateAudioScoreRate(-1 * audioValue);
                break;
            case "Table 3 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(3).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(3).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(3).updateAudioScoreRate(-1 * audioValue);
                break;
            case "Table 4 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(4).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(4).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(4).updateAudioScoreRate(-1 * audioValue);
                break;
            case "Table 5 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(5).updateDevScoreRate(-1 * codeValue);
                ScoreCache.getScoreManager(5).updateGraphicsScoreRate(-1 * graphicsValue);
                ScoreCache.getScoreManager(5).updateAudioScoreRate(-1 * audioValue);
                break;
            default:
                break;
        }

    }
}
