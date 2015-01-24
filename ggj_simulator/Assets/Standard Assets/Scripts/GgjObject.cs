using UnityEngine;
using System.Collections;

public class GgjObject : MonoBehaviour {
    bool activated;
    float graphicsValue;
    float audioValue;
    float codeValue;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = true;
    }

    public void OnTriggerExit(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
        Debug.Log(other.ToString());
    }
}
