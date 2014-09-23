using UnityEngine;
using System.Collections;

public class Pictures : MonoBehaviour {

    public bool curPicture;
    public int like;
    public int dislike;
    public int totalScore;

	// Use this for initialization
	void Start () {
        like = 0;
        dislike = 0;
	
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
