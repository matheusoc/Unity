using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//Posição do player.
	public Transform player;

	//Velocidade do movimento da camera.
	private Vector2 velocity;

	//Suavização do movimeno da camera.
	public float smooth;

	// Use this for initialization
	void Start () {
		velocity = new Vector2 (0.5f, 0.5f);
		smooth = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		//Calcula nova posição da camera com base no player.

		Vector3 newPosition = Vector3.zero;

		newPosition.x = Mathf.SmoothDamp (transform.position.x, player.position.x, 
			ref velocity.x, smooth);
		newPosition.y = Mathf.SmoothDamp (transform.position.y, player.position.y,
			ref velocity.y, smooth);

		newPosition.z = transform.position.z;

		transform.position = Vector3.Slerp (transform.position, newPosition, Time.time);
	}
}
