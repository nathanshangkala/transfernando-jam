﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundkiller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<AudioSource>().isPlaying == false){
			Destroy(gameObject,0.1f);
		}
	}
}
