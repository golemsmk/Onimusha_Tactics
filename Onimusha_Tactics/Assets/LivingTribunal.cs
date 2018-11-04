using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingTribunal : MonoBehaviour {

    public GameObject grassPrefab, riverPrefab, sandPrefab, lavaPrefab;

    private MapBlock[] map;

    private int height = 5;
    private int width = 4;
    
    // Use this for initialization
	void Start () {
        height = GetComponent<TestJson>().customObject.height;
        width = GetComponent<TestJson>().customObject.width;
        map = new MapBlock[height * width];
        for (int a=0;a<height;a++)
        {
            for(int b=0;b<width;b++)
            {
                map[a * width + b] = new MapBlock();
                map[a * width + b].codeIndex = GetComponent<TestJson>().customObject.layers[0].data[a*width+b]-1;
            }
        }
       
        GameObject tempGameObject, prefabSelection;
        prefabSelection = grassPrefab;
        for (int i = 1; i < height; i++)
        {
            for (int j = 1; j < width; j++)
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
    public int codeIndex;
}