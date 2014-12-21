using UnityEngine;
using System.Collections;

public class CameraButtonBehaviour : MonoBehaviour {

    public GameObject camScreen;

    public bool PicturesTaking, Decline, Accept;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnPress(bool isDown)
    {
        if (isDown && PicturesTaking)
        {
            camScreen.GetComponent<CameraScript>().TakeSnapshot();
        }

        if (isDown && Decline)
        {
            camScreen.GetComponent<CameraScript>().DeclinePicture();  
        }

        if (isDown && Accept)
        {
            camScreen.GetComponent<CameraScript>().AcceptPicture();
        }

    }
}
