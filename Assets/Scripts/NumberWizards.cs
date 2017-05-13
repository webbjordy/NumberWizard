﻿using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	
	// Use this for initialization
	void Start () {
		StartGame ();
		
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
	
		max = max + 1;
		
		print ("============================================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, down arror for lower, return for equals");
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is it higher or lower than " + guess + "?");
		print ("Up arrow for higher, down arror for lower, return for equals");
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print("Up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down arrow pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
		}
	}
}
