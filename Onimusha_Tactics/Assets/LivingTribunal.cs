using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingTribunal : MonoBehaviour {

    public GameObject cubePrefab, riverPrefab;

    public int height = 10;
    public int width = 8;
    
    // Use this for initialization
	void Start () {
        GameObject tempGameObject;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                tempGameObject = Instantiate(cubePrefab);
                tempGameObject.transform.position = new Vector3(1 * i, 0, 1 * j);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
