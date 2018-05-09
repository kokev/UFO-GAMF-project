using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject[] generatorPoints;
    public GameObject[] asteroids;

    private float _timer;
    private int _randomNumber = 0;


    List<GameObject> pooledObjectList;

    // Use this for initialization
    void Start () {

         _timer = 0;

        pooledObjectList = new List<GameObject>();

        for (int i = 0; i < asteroids.Length; i++)
        {
            GameObject obj = (GameObject)Instantiate(asteroids[i]);
            obj.SetActive(false);
            pooledObjectList.Add(obj);
        }

       // InvokeRepeating("AsteroidGenerator", 2.0f, 1.0f);

    }
	
	// Update is called once per frame
	void Update () {

        AsteroidGenerator();

    }

    public void AsteroidGenerator()
    {
        _randomNumber = Random.Range(0, generatorPoints.Length);

        Vector3 spawnPos = new Vector3(generatorPoints[_randomNumber].transform.position.x, generatorPoints[_randomNumber].transform.position.y, 0);

        _timer += Time.deltaTime;

        if (_timer > 1)
        {
            if (_randomNumber == 0 || _randomNumber == 13)
            {
                GameObject goRight = pooledObjectList[1];
                goRight.transform.position = spawnPos;
                goRight.transform.rotation = transform.rotation;
                goRight.SetActive(true);
                _timer = 0;
            }
            else if (_randomNumber == 5 || _randomNumber == 14)
            {
                GameObject goLeft = pooledObjectList[2];
                goLeft.transform.position = spawnPos;
                goLeft.transform.rotation = transform.rotation;
                goLeft.SetActive(true);
                _timer = 0;
            }
            else
            {
                GameObject go = pooledObjectList[0];
                go.transform.position = spawnPos;
                go.transform.rotation = transform.rotation;
                go.SetActive(true);
                _timer = 0;
            }
            
        }


        
    }

}
