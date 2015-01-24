using UnityEngine;
using System.Collections;

public class GgjObject : MonoBehaviour {
    bool activated;
    float graphicsValue;
    float audioValue;
    float codeValue;

	// Use this for initialization
	void Start () {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = true;
        Debug.Log("Trigger enter");
    }

    public void OnTriggerExit(Collider other) {
        (gameObject.GetComponent("Halo") as Behaviour).enabled = false;
        Debug.Log(other.ToString());
        Debug.Log("Trigger exit");
    }
}
