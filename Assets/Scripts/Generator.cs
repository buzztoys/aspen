using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;
using System.IO;
using System;

public class Generator : MonoBehaviour {

	public string filename;
	public GameObject blockPrefab;

	// Use this for initialization
	void Start () {
		// get the string from the source file
		string jsonString = Load (filename);

		// this is a list of Elements, however many were in the list of "elements":[]
		ElementInfo[] elements = JsonHelper.FromJson<ElementInfo>(jsonString);

		// this builds an element for each of the ElementInfo in the list
		Populate (elements);
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void Populate(ElementInfo[] elements)
	{
		Transform location = gameObject.transform;

		int counter = 0;
		foreach (ElementInfo elem in elements) {
			Vector3 offset = new Vector3 (3 * counter, 0, 0);
			GameObject created = Instantiate (blockPrefab, location.position + offset, location.rotation) as GameObject;
			created.GetComponent<ElementBehaviour> ().Learn (elem);
			counter += 1;
		}
	}

	private string Load(string filename)
	{
		try
		{
			string line;
			StreamReader theReader = new StreamReader(filename, Encoding.Default);
			StringBuilder jsonBuilder = new StringBuilder("");
			using (theReader)
			{
				// While there's lines left in the text file, do this:
				do
				{
					line = theReader.ReadLine();
					if (line != null)
					{
						jsonBuilder.Append(line.Trim());
					}
				}
				while (line != null);
				theReader.Close();
	
				string jsonStr = jsonBuilder.ToString();
				return jsonStr;
			}
		}
		// If anything broke in the try block, we throw an exception with information
		// on what didn't work
		catch (Exception e)
		{
			Debug.Log (e.Message);
			return "failed";
		}
	}
}
