using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillController : MonoBehaviour {

	public Transform groundCheck;

	public LayerMask spikes;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Physics2D.OverlapCircle (groundCheck.position, 0.05f, spikes)) {
			Application.LoadLevel ("gameover");
		}

	}
}
