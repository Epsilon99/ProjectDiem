using UnityEngine;
using System.Collections;

public class Pictures : MonoBehaviour {

    public bool curPicture;

    public int like;
    public int dislike;
    public int totalScore;

    public int nature;
    public int art;
    public int culture;
    public int people;
    public int architecture;
    public int explicitCategory;

	// Use this for initialization
	void Start () {
        //prints the saved playerpref from last time
        print(PlayerPrefs.GetInt("Nature Count"));

        like = PlayerPrefs.GetInt("Like Count");
        dislike = PlayerPrefs.GetInt("Dislike Count");

        nature = PlayerPrefs.GetInt("Nature Count");
        art = PlayerPrefs.GetInt("Art Count");
        culture = PlayerPrefs.GetInt("Culture Count");
        people = PlayerPrefs.GetInt("People Count");
        architecture = PlayerPrefs.GetInt("Architecture Count");
        explicitCategory = PlayerPrefs.GetInt("Explicit Count");
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x == 0)
        {
            curPicture = true;
        }
        totalScore = like - dislike;
        //resets playerprefs
        if(Input.GetKeyDown(KeyCode.R))
        {
            like = 0;
            dislike = 0;

            nature = 0;
            art = 0;
            culture = 0;
            people = 0;
            architecture = 0;
            explicitCategory = 0;
        }
	
	}
    void OnApplicationQuit()
    {
        //saves the category playerprefs
        PlayerPrefs.SetInt("Nature Count", nature);
        PlayerPrefs.SetInt("Art Count", art);
        PlayerPrefs.SetInt("Culture Count", culture);
        PlayerPrefs.SetInt("People Count", people);
        PlayerPrefs.SetInt("Architecture Count", architecture);
        PlayerPrefs.SetInt("Explicit Count", explicitCategory);
        print(PlayerPrefs.GetInt("Nature Count"));

        PlayerPrefs.SetInt("Like Count", like);
        PlayerPrefs.SetInt("Dislike Count", dislike);
    }
}
