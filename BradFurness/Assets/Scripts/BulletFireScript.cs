using UnityEngine;
using System.Collections.Generic;


public class BulletFireScript : MonoBehaviour {

	public float fireTime = 0.5f;
	public GameObject bullet;

	public int pooledAmount = 20;

	private List<GameObject> bullets = new List<GameObject>();

	void Start()
	{

		for (int i = 0; i < pooledAmount; i++)
		{
			GameObject obj = (GameObject)Instantiate(bullet);
			obj.SetActive(false);
			bullets.Add(obj);

		}
		if (Input.GetKeyDown ("space")) {
			Fire ();
		}
	}

	void Fire()
	{
		for(int i = 0; i <bullets.Count;i++)
		{
			if(!bullets[i].activeInHierarchy)
			{

		bullets[i].transform.position = transform.position;
		bullets[i].transform.rotation = transform.rotation;
		bullets[i].SetActive(true);
		break;
			}
		}

	}
}


