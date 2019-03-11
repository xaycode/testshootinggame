using UnityEngine;
using System.Collections;

public class tembakan : MonoBehaviour 
{

	public Rigidbody pelurunya;
	public Transform posisiTembak;
	public float powernya = 1000f;
	public float kecepatanpeluru = 10f;

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * kecepatanpeluru;
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * kecepatanpeluru;
		transform.Translate (new Vector3 (h, v, 0));
		if (Input.GetButtonUp ("Fire1")) {
			Rigidbody peluru = Instantiate (pelurunya, posisiTembak.position, posisiTembak.rotation) as Rigidbody;
			peluru.AddForce (posisiTembak.forward * powernya);
		}
	}
}
