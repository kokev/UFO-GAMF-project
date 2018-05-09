using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidForceRight : MonoBehaviour {

    public int thrust;

    private Rigidbody2D _asteroidRb;

    // Use this for initialization
    void Start () {

       _asteroidRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _asteroidRb.AddForce(transform.right * thrust);
        //_asteroidRb.AddForce(transform.up * thrust);
    }
}
