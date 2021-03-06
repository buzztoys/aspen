﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject user;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - user.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = user.transform.position + offset;
	}
}
