using UnityEngine;
using System.Collections;

public class ChairBehaviour : MonoBehaviour
{

	void Start ()
    {
        gameObject.renderer.transform.Rotate(new Vector3(270, 0, 0));
	}
	
	void Update ()
    {
	
	}
}
