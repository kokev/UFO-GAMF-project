using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecameInvisible : MonoBehaviour {

    private void OnBecameInvisible()
    {
        transform.parent.gameObject.SetActive(false);
        Debug.Log("kurvaanyad");
    }
}
