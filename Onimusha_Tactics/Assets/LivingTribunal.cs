using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingTribunal : MonoBehaviour {

    public GameObject grassPrefab, riverPrefab, sandPrefab, lavaPrefab;

    public MapBlock[] map;

    public int height = 5;
    public int width = 4;
    
    // Use this for initialization
	void Start () {
        GameObject tempGameObject, prefabSelection;
        prefabSelection = grassPrefab;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[i*width+j].codeIndex == 0)
                {
                    prefabSelection = grassPrefab;
                }
                else if (map[i * width + j].codeIndex == 1)
                {
                    prefabSelection = riverPrefab;
                }
                else if (map[i * width + j].codeIndex == 2)
                {
                    prefabSelection = sandPrefab;
                }
                else if (map[i * width + j].codeIndex == 3)
                {
                    prefabSelection = lavaPrefab;
                }
                tempGameObject = Instantiate(prefabSelection);
                tempGameObject.transform.position = new Vector3(1 * i, 0, 1 * j);
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