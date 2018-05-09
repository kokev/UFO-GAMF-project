using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float speed;

    private Rigidbody2D _cameraRigidbody;

    // Use this for initialization
    void Start () {

        _cameraRigidbody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        Vector2 cameraMovement = new Vector2(0, 1);
        _cameraRigidbody.velocity = cameraMovement * speed;

    }
}
