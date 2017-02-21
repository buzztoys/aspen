using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
    public Transform spawn1;
    public Transform spawn2;
    public GameObject cube;
    public GameObject sphere;
    public static string stringtoEdit = "000";
    private void OnGUI ()
    {
        stringtoEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringtoEdit, 25);
    }

    void Start () {
		
	}
	
	void Update () {
        int numCubes = int.Parse(stringtoEdit);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            int counter = 0;
            while (numCubes > 0)
            {
                if (numCubes <= 10)
                {
                    Instantiate(cube, spawn1.position + new Vector3(0, 0, counter-10), spawn1.rotation);
                    numCubes--;
                    counter+=2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 20)
                {
                    Instantiate(cube, spawn1.position + new Vector3(-2, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter+=2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 30)
                {
                    Instantiate(cube, spawn1.position + new Vector3(2, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter+=2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 40)
                {
                    Instantiate(cube, spawn1.position + new Vector3(-4, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter+=2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 50)
                {
                    Instantiate(cube, spawn1.position + new Vector3(4, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter+=2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 60)
                {
                    Instantiate(cube, spawn1.position + new Vector3(-6, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter += 2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 70)
                {
                    Instantiate(cube, spawn1.position + new Vector3(6, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter += 2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 80)
                {
                    Instantiate(cube, spawn1.position + new Vector3(-8, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter += 2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 90)
                {
                    Instantiate(cube, spawn1.position + new Vector3(8, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter += 2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
                else if (numCubes <= 100)
                {
                    Instantiate(cube, spawn1.position + new Vector3(10, 0, counter - 10), spawn1.rotation);
                    numCubes--;
                    counter += 2;
                    if (counter == 20)
                    {
                        counter = 0;
                    }
                }
            }
            
        }
            if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(cube, spawn1.position, spawn1.rotation);
            Instantiate(cube, spawn2.position, spawn2.rotation);
        }
            
            if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(sphere, spawn1.position, spawn1.rotation);
        }
    }
}