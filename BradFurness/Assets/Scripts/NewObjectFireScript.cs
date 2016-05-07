using UnityEngine;
using System.Collections;

public class NewObjectFireScript : MonoBehaviour {

	public float fireTime = .05f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", fireTime, fireTime);

	}
	
	// Update is called once per frame
	void Fire () {
	
		GameObject obj = NewObjectPoolerScript.current.GetPooledObject ();

		if(obj == null) return;

		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
	}
}
