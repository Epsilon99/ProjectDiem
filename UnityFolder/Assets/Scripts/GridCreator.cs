using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridCreator : MonoBehaviour {

    private string directory;
    public Object[] derpFace;

    void Awake() {
        directory = Application.persistentDataPath + "/pictures";
    }

	// Use this for initialization
	void Start () {
        derpFace = Resources.LoadAll(directory);

	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
