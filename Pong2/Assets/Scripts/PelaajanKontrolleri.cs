using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelaajanKontrolleri : MonoBehaviour
{
    public float nopeus;
    public Transform taustaT;

    private float taustanKorkeus;
    private float omaKorkeus;

	private void Start()
	{
        taustanKorkeus = taustaT.localScale.y * 0.5f;
        omaKorkeus = transform.localScale.y * 0.5f;
        transform.position = new Vector3(taustaT.localScale.x * -0.5f + 1, 0, 0);
	}

	// Update is called once per frame
	void Update()
    {
        // Otetaan pelaajalta syöte
        float suunta = Input.GetAxisRaw("Vertical") * Time.deltaTime * nopeus;
        

        if (transform.position.y + suunta < taustanKorkeus - omaKorkeus
            && transform.position.y + suunta > -taustanKorkeus + omaKorkeus)
        {
            transform.Translate(new Vector3(0, suunta, 0));
        }

    }
}
