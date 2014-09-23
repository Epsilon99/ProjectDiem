using UnityEngine;
using System.Collections;

public class LikeDislike : MonoBehaviour {

    private Pictures pictureLikedislike;

	// Use this for initialization
	void Start () {

        pictureLikedislike = GameObject.Find("AC3").GetComponent<Pictures>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + 35, 150, 60, 30), "Dislike"))
        {
            Debug.Log("Clicked Dislike");
            pictureLikedislike.dislike++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2 -95, 150, 60, 30), "Like"))
        {
            Debug.Log("Clicked Like");
            pictureLikedislike.like++;
            Destroy(gameObject);
        }
    }
}
