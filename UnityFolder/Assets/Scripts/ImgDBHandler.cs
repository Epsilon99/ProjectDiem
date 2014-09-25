using UnityEngine;
using System.Collections;
using System.IO;

public class ImgDBHandler : MonoBehaviour {

    private string directory;
    private bool areWeSearching;
    public int curImg = 0;

    public GameObject GridThumbnail;

    void Awake(){
        directory = Application.persistentDataPath;
    }

	// Use this for initialization
	void Start () {
        areWeSearching = true;

	    while(areWeSearching){

            if (File.Exists(directory + "/MyImage" + curImg + ".png") == false)
            {
                areWeSearching = false;   
            }
            else {
                curImg++;
            }
        }

        if(curImg!=0)
            derpFace();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void derpFace(){

        Debug.Log("herpe de derpede");

        int imageToPrint = Random.Range(0,curImg);
        string pathToImage = directory + "/MyImage" + imageToPrint + ".png";
        var bytes = File.ReadAllBytes(pathToImage);
        Texture2D imgTexture = new Texture2D(73,73);
        imgTexture.LoadImage(bytes);
        GridThumbnail.renderer.material.mainTexture = imgTexture;
    }
}
