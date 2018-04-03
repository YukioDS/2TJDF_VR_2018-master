using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour {

    public float intervalo = 3f;
    public float area = 4f;
    public GameObject zumbiOrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GerarZumbi", intervalo, intervalo);
	}

    private void GerarZumbi()
    {
        GameObject zumbi = Instantiate(zumbiOrefab);
        Vector2 posicaoAleatoria = Random.insideUnitCircle * area;
        zumbi.transform.position = new Vector3(posicaoAleatoria.x, 0f, posicaoAleatoria.y);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
