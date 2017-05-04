using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;
using System.IO;
using System;


public class Generator : MonoBehaviour {

	public string filename;

	// Use this for initialization
	void Start () {
		// get the string from the source file
		string jsonString = Load (filename);

		// this is a list of Elements, however many were in the list of "elements":[]
		ElementInfo[] elements = JsonHelper.FromJson<ElementInfo>(jsonString);

		Populate (elements);
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void Populate(ElementInfo[] elements)
	{
		foreach (ElementInfo elem in elements) {
			Debug.Log (elem.name);
			Debug.Log (elem.type);
		}
	}

	private string Load(string filename)
	{
		try
		{
			string line;
			StreamReader theReader = new StreamReader(filename, Encoding.Default);
			// Immediately clean up the reader after this block of code is done.
			// You generally use the "using" statement for potentially memory-intensive objects
			// instead of relying on garbage collection.
			// (Do not confuse this with the using directive for namespace at the 
			// beginning of a class!)
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
