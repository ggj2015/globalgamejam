using UnityEngine;
using System;
using System.Collections;

public class Pickup : MonoBehaviour {
    GameObject carriedObj;
    bool currMouseDown = false;
    bool prevMouseDown = false;

    void Start() {

    }

    void MousePickUpCallback() {
        if (currMouseDown && prevMouseDown == false) {
            if (carriedObj == null) {
                OnLeftClick();
            } else {
                carriedObj = null;
            }
        }
    }

    // Casts a ray infinitely long to find an object
    void OnLeftClick() {
        Debug.Log("OnLeftClick");
        RaycastHit hit;
        if (Physics.SphereCast(new Ray(transform.position + transform.forward * 2.0f,
                                       transform.forward), 3.0f, out hit)) {
            if (hit.collider.gameObject.rigidbody != null) {
                carriedObj = hit.collider.gameObject;
            }
        }
    }  

    void ObjectTrail() {
        if (carriedObj != null) {

            Vector3 dest = transform.position + new Vector3(transform.forward.x, 0, transform.forward.z) * 5.0f;
            Vector3 delta = dest - carriedObj.transform.position;
            if (delta.magnitude > 0.1f) {
                carriedObj.rigidbody.velocity = delta * 10.0f;
            } else {
                carriedObj.rigidbody.velocity = Vector3.zero;
            }            
        }
    }

    void FixedUpdate() {
        currMouseDown = Input.GetMouseButtonDown(0);
        MousePickUpCallback();
        ObjectTrail();
        prevMouseDown = currMouseDown;
    }
}


