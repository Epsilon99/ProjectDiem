using UnityEngine;
using System.Collections;

public class LikeDislike : MonoBehaviour {

    private Pictures pictureScript;

	// Use this for initialization
	void Start () {

        pictureScript = GameObject.Find("AC3").GetComponent<Pictures>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + 35, 150, 60, 30), "Dislike") && pictureScript.curPicture==true)
        {
            Debug.Log("Clicked Dislike");
            pictureScript.dislike++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2 -95, 150, 60, 30), "Like") && pictureScript.curPicture==true)
        {
            Debug.Log("Clicked Like");
            pictureScript.like++;
            Destroy(gameObject);
        }
    }
}
