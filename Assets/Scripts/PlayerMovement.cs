using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Animator playerAnimator;
	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;

	// Use this for initialization
	void Start () {
		// Gather the Animator component from the Player GameObject
		playerAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		// Gather input from the keyboard
		moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertical = Input.GetAxisRaw("Vertical");

		movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	}

	void FixedUpdate () {
		// If the player's movement Vector does not equal to 0...
		if (movement != Vector3.zero) {
			//...then plat the jump animation
			playerAnimator.SetFloat("Speed", 3f);
		} else {
			// Otherwise, don't play the animation
			playerAnimator.SetFloat("Speed", 0f);
		}

	}
}
