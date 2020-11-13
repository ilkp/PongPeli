using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallo : MonoBehaviour
{
    private Rigidbody omaRb;
    public float nopeus;

    // Start is called before the first frame update
    void Start()
    {
        omaRb = GetComponent<Rigidbody>();
        Alusta();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Alusta()
	{
        transform.position = Vector3.zero; // tarkoittaa samaa kuin new Vector3(0, 0, 0)
        float kulma = Random.Range(0, 360);
        float xSuunta = Mathf.Cos(kulma * Mathf.Deg2Rad);
        float ySuunta = Mathf.Sin(kulma * Mathf.Deg2Rad);
        omaRb.velocity = Vector3.zero;
        omaRb.AddForce(new Vector3(xSuunta, ySuunta, 0) * nopeus, ForceMode.Impulse);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("YlaAlaSeinat"))
		{
            Vector3 uusiNopeus = new Vector3(omaRb.velocity.x, omaRb.velocity.y * -1, 0);
            omaRb.velocity = uusiNopeus;
		}
	}
}
