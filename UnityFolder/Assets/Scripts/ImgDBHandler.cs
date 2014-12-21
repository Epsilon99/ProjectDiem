using UnityEngine;
using System.Collections;
using System.IO;

public class ImgDBHandler : MonoBehaviour {

    private string directory;
    private bool areWeSearching;
    public int curImg = 1;

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
            ChangeGrid();

	}
	
	// Update is called once per frame
	void Update () {

	}

    private void ChangeGrid() {
        GameObject[] grids = GameObject.FindGameObjectsWithTag("Thumbnail");

        foreach(GameObject obj in grids){
            int imageToPrint = Random.Range(1, curImg);
            string pathToImage = directory + "/MyImage" + imageToPrint + ".png";
            var bytes = File.ReadAllBytes(pathToImage);
            Texture2D imgTexture = new Texture2D((int)obj.renderer.bounds.size.x, (int)obj.renderer.bounds.size.y);
            imgTexture.LoadImage(bytes);
            obj.renderer.material.mainTexture = imgTexture;
            obj.GetComponent<Thumbnail>().ImagePath = pathToImage;
            obj.GetComponent<Thumbnail>().ImageNumber = imageToPrint;
        }
    }
}
