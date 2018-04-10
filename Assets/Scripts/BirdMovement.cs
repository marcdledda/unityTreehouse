using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {

	[SerializeField]
	private Transform target;
	private UnityEngine.AI.NavMeshAgent birdAgent;
	private Animator birdAnimator;

	// Use this for initialization
	void Start () {
		birdAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		birdAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		// Set the bird's destination
		birdAgent.SetDestination(target.position);
		// Measure the magnitutde of the NashMeshAgent's velocity
		float speed = birdAgent.velocity.magnitude;
		//Pass the velocity to the animator component
		birdAnimator.SetFloat("Speed", speed);
	}
}
