using UnityEngine;
using System.Collections;

public class Rating : MonoBehaviour {

    public GameObject likeDislike;
    public GameObject categoryOptions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 1.5f, 300, 70, 30), "Rating"))
        {
            Debug.Log("Clicked Rating");
            Instantiate(likeDislike, new Vector2(0,0), Quaternion.identity);
        }

        if (GUI.Button(new Rect(Screen.width / 11, 300, 70, 30), "Category"))
        {
            Debug.Log("Clicked Rating");
            Instantiate(categoryOptions, new Vector2(0, 0), Quaternion.identity);
        }

    }
}
