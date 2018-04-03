using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

    private bool andando = false;
    public float delayAndar = 1.5f;
    public Rigidbody rb;
    private float velocidade = 0.35f;
    private GameObject jogador;
    // Use this for initialization
    void Start ()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");

        transform.LookAt(jogador.transform);

        Invoke("Andar", delayAndar);
	}

    private void Andar()
    {
        andando = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (andando)
        {
            rb.velocity = (jogador.transform.position - transform.position).normalized * velocidade;
        }
	}
}
