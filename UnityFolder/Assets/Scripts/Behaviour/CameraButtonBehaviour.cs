using UnityEngine;
using System.Collections;

public class CameraButtonBehaviour : MonoBehaviour {

    public GameObject camScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnPress(bool isDown)
    {
        if (isDown)
        {
            camScreen.GetComponent<CameraScript>().TakeSnapshot();
        }

    }
}
