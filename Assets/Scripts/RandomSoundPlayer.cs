﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour {

	private AudioSource audioSource;
	[SerializeField]
	private List<AudioClip> soundClips = new List<AudioClip>();
	[SerializeField]
	private float soundTimerDelay = 3f;
	private float soundTimer;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// Increment a time to count u to restarting
		soundTimer = soundTimer + Time.deltaTime;
		// If the timer reaches the delay...
		if (soundTimer >= soundTimerDelay) {
			//...reset the time...
			soundTimer = 0f;
			//...choose a random sound...
			AudioClip randomSound = soundClips[Random.Range(0, soundClips.Count)];
			audioSource.PlayOneShot(randomSound);
		}
	}
}
