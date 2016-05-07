using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
