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
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 10, 80, 30), "Nature") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked Nature");
            pictureLikedislike.nature++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 5, 80, 30), "Art") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked Art");
            pictureLikedislike.art++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 3, 80, 30), "Culture") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked Culture");
            pictureLikedislike.culture++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 2, 80, 30), "People") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked People");
            pictureLikedislike.people++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 1.7f, 80, 30), "Architecture") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked Architecturee");
            pictureLikedislike.architecture++;
            Destroy(gameObject);
        }
        if (GUI.Button(new Rect(Screen.width / 2.8f, Screen.height / 1.5f, 80, 30), "18+") && pictureLikedislike.curPicture == true)
        {
            Debug.Log("Clicked 18+");
            pictureLikedislike.explicitCategory++;
            Destroy(gameObject);
        }
    }
}
