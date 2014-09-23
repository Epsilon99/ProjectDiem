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
        like = 0;
        dislike = 0;

        nature = 0;
        art = 0;
        culture = 0;
        people = 0;
        architecture = 0;
        explicitCategory = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x == 0)
        {
            curPicture = true;
            totalScore = like - dislike;
        }
	
	}
}
