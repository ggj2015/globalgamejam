using UnityEngine;
using System.Collections;

public class TableTrigger : MonoBehaviour {
	// Use this for initialization
	void Start () {
        // Assign this trigger to the team it belongs to for updating score
        string tableName = transform.parent.gameObject.ToString();
        // the score I want is tableName "table3" -> team3
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnTriggerEnter(Collider other) {
        // Only highlight if in the player's table area
        string tableName = transform.parent.gameObject.ToString();

        // Get the team table it's colliding with and add to its score
        switch (tableName)
        {
            case "Table 0 (UnityEngine.GameObject)":
                
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
        // Only highlight if in the player's table area
        string tableName = transform.parent.gameObject.ToString();

        // Get the team table it's colliding with and add to its score
        switch (tableName)
        {
            case "Table 0 (UnityEngine.GameObject)":
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
}
