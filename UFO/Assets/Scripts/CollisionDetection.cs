using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour {

    private Collider2D _collider;

    public GameObject gameOverScreen;

    public GameObject canvas;
    private UIscript _uiScript;

    public void Awake()
    {

        _uiScript = canvas.GetComponent<UIscript>();

        Collider2D[] colliders = GetComponents<Collider2D>();

        gameOverScreen.SetActive(false);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].isTrigger)
            {
                _collider = colliders[i];
                break;
            }
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            _uiScript.HighScore();
        }
        if(collision.gameObject.tag == "Enemy")
        {
            
           GameObject asteroid = GameObject.FindWithTag("Enemy");
            asteroid.transform.gameObject.SetActive(false);

            Debug.Log("invisible");
        }
    }

}
