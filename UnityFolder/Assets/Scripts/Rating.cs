using UnityEngine;
using System.Collections;

public class Rating : MonoBehaviour {

    public GameObject likeDislike;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 + 25, 300, 50, 30), "Rating"))
        {
            Debug.Log("Clicked Rating");
            Instantiate(likeDislike, new Vector2(0,0), Quaternion.identity);
        }
    }
}
