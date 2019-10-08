using UnityEngine;
using System.Collections;

public class scpScn1 : MonoBehaviour {

	private AudioSource sndPop;
	private ParticleSystem pS;
	private Light miLuz;

	//public float zSpeed = 4f;

	int i;

	void Start (){

		sndPop = GetComponent<AudioSource> ();
		//pS = GetComponent<ParticleSystem> ();
		miLuz = GetComponent<Light>();

	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);

			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
			if (hit.collider != null) {

				for(int i = 0; i < Input.touchCount; i++)

				miLuz.enabled = true;
				sndPop.Play ();
				//pS.Play ();
				i++;
				Debug.Log (i);

				//transform.Rotate (0, 0, zSpeed);

				//		hit.collider.attachedRigidbody.AddForce(Vector2.up);
			}
		} else {
           if (Input.GetMouseButtonUp(0))
			miLuz.enabled = false;
		}
	}

}