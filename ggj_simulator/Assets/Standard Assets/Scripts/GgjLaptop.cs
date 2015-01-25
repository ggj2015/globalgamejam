using UnityEngine;
using System.Collections;

public class GgjLaptop : GgjObject {

    void Awake() {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
        codeValue = 0.1f;
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
