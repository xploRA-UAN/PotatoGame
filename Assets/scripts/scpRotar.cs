using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpRotar : MonoBehaviour {

	public float zSpeed = 0.5f;

	void FixedUpdate() {

				transform.Rotate (0, 0, zSpeed);


	}
}