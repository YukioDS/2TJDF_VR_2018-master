using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

    private bool andando = false;
    public float delayAndar = 1.5f;

    // Use this for initialization
    void Start ()
    {
        Invoke("Andar", delayAndar);
	}

    private void Andar()
    {
        andando = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}
}
