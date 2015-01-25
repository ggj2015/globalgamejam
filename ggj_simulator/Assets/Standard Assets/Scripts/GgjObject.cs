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
        switch (tableName)
        {
            case "Table 0 (UnityEngine.GameObject)":
                ScoreCache.getScoreManager(0).updateDevScoreRate((int) codeValue);
                break;
            case "Table 1 (UnityEngine.GameObject)":
                break;
            case "Table 2 (UnityEngine.GameObject)":
                break;
            case "Table 3 (UnityEngine.GameObject)":
                break;
            case "Table 4 (UnityEngine.GameObject)":
                break;
            case "Table 5 (UnityEngine.GameObject)":
                break;
            default:
                break;
        }
    }

    public void OnTriggerExit(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
    }
}
