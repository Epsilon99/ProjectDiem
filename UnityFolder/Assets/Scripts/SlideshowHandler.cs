using UnityEngine;
using System.Collections;
using System.IO;

public class SlideshowHandler : MonoBehaviour {

    public int CurImageNumber;
    public GameObject ChoosenImage;
    public GameObject curImage;
    private GameObject rightChecker;
    private GameObject leftChecker;
    private GameObject midChecker;
    public GameObject idleImageHolder;
    private GameObject ImageHandlerGO;
    private string directory;

    private bool areWeSwitching = false;
    private bool isNewOnLeft;

    void Awake()
    {
        directory = Application.persistentDataPath;
    }


	// Use this for initialization
	void Start () {
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
        midChecker = GameObject.FindGameObjectWithTag("MidChecker");
        ImageHandlerGO = GameObject.FindGameObjectWithTag("ImageHandler");
	}
	
	// Update is called once per frame
	void Update () {
        Controls();
	}

    void Controls()
    {
        if (areWeSwitching && ChoosenImage != null)
        {
            {
                if (isNewOnLeft)
                {
                    curImage.GetComponent<MenuBehaviour>().SlideToTheSide(false);
                    ChoosenImage.GetComponent<MenuBehaviour>().SlideToCenter();
                    curImage = ChoosenImage;
                    areWeSwitching = false;
                    ChoosenImage = null;
                }
                else
                {
                    curImage.GetComponent<MenuBehaviour>().SlideToTheSide(true);
                    ChoosenImage.GetComponent<MenuBehaviour>().SlideToCenter();
                    curImage = ChoosenImage;
                    areWeSwitching = false;
                    ChoosenImage = null;
                }
            }
        }
    }

    public void ChangeChoosenImageSideways(bool isItLeft)
    {
        ChoosenImage = idleImageHolder;
        idleImageHolder = curImage;
        ChoosenImage.SetActive(true);

        if (isItLeft)
        {
            if (CurImageNumber - 1 != 0)
                CurImageNumber -= 1;
            else
                CurImageNumber = (ImageHandlerGO.GetComponent<ImgDBHandler>().curImg) - 1;
            
            ChoosenImage.transform.position = leftChecker.transform.position;
            isNewOnLeft = true;
        }
        else
        {
            CurImageNumber += 1;
            ChoosenImage.transform.position = rightChecker.transform.position;
            isNewOnLeft = false;
        }

        if (File.Exists(directory + "/MyImage" + CurImageNumber + ".png") == false)
        {
            CurImageNumber = 1;
        }

        string pathToImage = directory + "/MyImage" + CurImageNumber + ".png";
        var bytes = File.ReadAllBytes(pathToImage);
        Texture2D imgTexture = new Texture2D((int)ChoosenImage.renderer.bounds.size.x, (int)ChoosenImage.renderer.bounds.size.y);
        imgTexture.LoadImage(bytes);
        ChoosenImage.renderer.material.mainTexture = imgTexture;


        areWeSwitching = true;
    }
}
