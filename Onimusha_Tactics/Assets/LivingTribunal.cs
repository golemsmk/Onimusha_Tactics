using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingTribunal : MonoBehaviour {

    public GameObject cubePrefab, riverPrefab, sandPrefab;

    public MapBlock[] map;

    public int height = 5;
    public int width = 4;
    
    // Use this for initialization
	void Start () {
        GameObject tempGameObject;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[i*width+j].codeIndex == 0)
                {
                    tempGameObject = Instantiate(riverPrefab);
                    tempGameObject.transform.position = new Vector3(1 * i, 0, 1 * j);
                }
                else if (map[i * width + j].codeIndex == 1)
                {
                    tempGameObject = Instantiate(cubePrefab);
                    tempGameObject.transform.position = new Vector3(1 * i, 0, 1 * j);
                }
                else if (map[i * width + j].codeIndex == 2)
                {
                    tempGameObject = Instantiate(sandPrefab);
                    tempGameObject.transform.position = new Vector3(1 * i, 0, 1 * j);
                }
                
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
[System.Serializable]
public class MapBlock
{
    public int codeIndex = 0;
}