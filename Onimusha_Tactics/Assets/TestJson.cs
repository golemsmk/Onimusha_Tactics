using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJson : MonoBehaviour {
    public string map;

    public TestObject customObject;

	// Use this for initialization
	void Start () {
        customObject = JsonUtility.FromJson<TestObject>(map);
        GetComponent<LivingTribunal>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

[System.Serializable]
public class TestObject
{
    public int height;
    public Test1[] layers;
    public int nextobjectid;
    public string orientation;
    public string renderorder;
    public string tiledversion;
    public int tileheight;
    public Test2[] tilesets;
    public int width;
    public int tilewidth;
    public int version;
    public string type;
}

[System.Serializable]
public class Test1
{
    public int[] data;
    public int height;
    public string name ;
    public int opacity;
    public string type;
    public bool visible;
    public int width;
    public int x;
    public int y;
  
}
[System.Serializable]
public class Test2
{
    public int firstgid;
    public string source;
}