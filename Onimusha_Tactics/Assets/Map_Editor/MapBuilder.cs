using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour {

    public string mapDataDirectoryPath;

    private MapContainer currentMap;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // this one is for welcome screen
    private GameObject currentMenu;
    public void GoToNextMenu(GameObject targetGameObject)
    {
        currentMenu.SetActive(false);
        currentMenu = targetGameObject;
        currentMenu.SetActive(true);
    }

    public void InitNewMap(int width, int height)
    {
        currentMap = new MapContainer(width, height);
    }

    public void LoadMap(string mapName)
    {
        currentMap = Resources.Load<MapContainer>(mapDataDirectoryPath+"/"+mapName);
    }
}

[CreateAssetMenu(fileName = "Map",menuName = "Custom Map", order = 0)]
public class MapContainer : ScriptableObject
{
    int width, height;

    Vector3Int[] layerTerrain, layerObject, layerMonster, layerCharacter;

    bool verified;

    public MapContainer(int width, int height)
    {
        verified = false;
        this.width = width;
        this.height = height;
        layerTerrain = new Vector3Int[width*height];
    }

    public bool IsVerified()
    {
        return verified;
    }
}