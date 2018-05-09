using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public int scrollingSpeed = 15;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.y += Time.deltaTime / scrollingSpeed;
        mat.mainTextureOffset = offset;

	}


}
