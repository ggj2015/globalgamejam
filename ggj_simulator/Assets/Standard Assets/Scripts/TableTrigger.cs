﻿using UnityEngine;
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

    }

    public void OnTriggerExit(Collider other) {
        // Only highlight if in the player's table area
    }
}
