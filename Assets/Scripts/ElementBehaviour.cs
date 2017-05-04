using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementBehaviour : MonoBehaviour {

	public GameObject text;
	private GameObject floating;
	private ElementInfo info;
	private bool showText = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			showText = !showText;
			floating.GetComponent<Renderer>().enabled = showText;
		}
	}

	public void Learn(ElementInfo information) {
		info = information;

		Vector3 textLocation = transform.position + new Vector3(0,2,0);
		floating = Instantiate (text, textLocation, Quaternion.identity);
		floating.GetComponent<Renderer> ().enabled = showText;
		floating.GetComponent<TextMesh> ().text = info.name;
	}

}
