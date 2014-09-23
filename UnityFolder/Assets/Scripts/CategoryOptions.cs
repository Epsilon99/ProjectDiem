using UnityEngine;
using System.Collections;

public class CategoryOptions : MonoBehaviour {

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
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height/10, 60, 30), "Nature"))
        {
            Debug.Log("Clicked Nature");
            pictureLikedislike.nature++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 5, 60, 30), "Art"))
        {
            Debug.Log("Clicked Art");
            pictureLikedislike.art++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 3, 60, 30), "Culture"))
        {
            Debug.Log("Clicked Culture");
            pictureLikedislike.culture++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 2, 60, 30), "People"))
        {
            Debug.Log("Clicked People");
            pictureLikedislike.people++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 1.7f, 60, 30), "Architecture"))
        {
            Debug.Log("Clicked Architecturee");
            pictureLikedislike.architecture++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 1.5f, 60, 30), "18+"))
        {
            Debug.Log("Clicked 18+");
            pictureLikedislike.explicitCategory++;
            Destroy(gameObject);
        }
    }
}
