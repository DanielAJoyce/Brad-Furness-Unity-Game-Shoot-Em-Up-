using UnityEngine;
using System.Collections;

public class PlayerShip : MonoBehaviour {
	public float speed;
	public GameObject PlayerBlueBullet1;
	public GameObject PlayerBulletPositon1;
	public GameObject PlayerBulletPosition2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			GameObject bullet01 = (GameObject)Instantiate (PlayerBlueBullet1);
			bullet01.transform.position = PlayerBulletPositon1.transform.position;

			GameObject bullet2 = (GameObject)Instantiate (PlayerBlueBullet1);
			bullet2.transform.position = PlayerBulletPosition2.transform.position;


		}

		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");

		Vector2 direction = new Vector2 (x, y).normalized;

		Move(direction);


	}

	void Move(Vector2 direction)
	{
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0,0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

		max.x = max.x - 1.985f;
		min.x = min.x - 1.985f;

		max.y = max.y - 0.745f;
		min.y = min.y - 0.745f;

		Vector2 pos = transform.position;
	
		pos += direction * speed * Time.deltaTime;

		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		transform.position = pos;
	}
}
