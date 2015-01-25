using UnityEngine;
using System.Collections;

public class GgjObject : MonoBehaviour {
    float graphicsValue;
    float audioValue;
    float codeValue;

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
        Debug.Log(tableName);

        if (tableName == "Table (UnityEngine.GameObject)") { // HACK needs to change if table name changes
            (gameObject.GetComponent("Halo") as Behaviour).enabled = true;
        }
    }

    public void OnTriggerExit(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
    }
}
