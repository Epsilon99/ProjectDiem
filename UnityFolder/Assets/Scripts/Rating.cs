using UnityEngine;
using System.Collections;

public class Rating : MonoBehaviour {

    public GameObject likeDislike;
    public GameObject categoryOptions;

    public Pictures pictureLikedislike;

	// Use this for initialization
	void Start () {

        pictureLikedislike = GameObject.Find("AC3").GetComponent<Pictures>();
        //prints the saved playerpref from last time
        print(PlayerPrefs.GetInt("Nature Count"));
        //sets the above playerpref to the new value on the picture
        pictureLikedislike.nature = PlayerPrefs.GetInt("Nature Count");
	
	
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
