using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {

    public GameObject curMenu;

    public GameObject ChoosenScreen;

    private bool areWeSwitching;
    private bool isNewOnLeft;
    private bool isNewOnTop;
    private bool slideSideway = false;
    private bool slideVertical = false;

    private GameObject botChecker;
    private GameObject topCecker;
    private GameObject leftChecker;
    private GameObject rightChecker;
    public GameObject MainMenu;

	// Use this for initialization
	void Start () {
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
        botChecker = GameObject.FindGameObjectWithTag("BotChecker");
        topCecker = GameObject.FindGameObjectWithTag("TopChecker");
	}
	
	// Update is called once per frame
	void Update () {

        Controls();
        
	}

    void Controls() {

        if(Input.GetKeyDown(KeyCode.Escape)){
            PreviousMenu();
        }

        if (areWeSwitching && ChoosenScreen != null) {
            if (slideSideway)
            {
                if (isNewOnLeft)
                {
                    curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(false);
                    ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter();
                    curMenu = ChoosenScreen;
                    areWeSwitching = false;
                    ChoosenScreen = null;
                    slideSideway = false;
                }
                else
                {
                    curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(true);
                    ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter();
                    curMenu = ChoosenScreen;
                    areWeSwitching = false;
                    ChoosenScreen = null;
                    slideSideway = false;
                }
            }

            if(slideVertical)
            {
                if (isNewOnTop)
                {
                    curMenu.GetComponent<MenuBehaviour>().SlideVertically(true);
                    ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter();
                    curMenu = ChoosenScreen;
                    areWeSwitching = false;
                    ChoosenScreen = null;
                    slideVertical = false;
                }
                else
                {
                    curMenu.GetComponent<MenuBehaviour>().SlideVertically(false);
                    ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter();
                    curMenu = ChoosenScreen;
                    areWeSwitching = false;
                    ChoosenScreen = null;
                    slideVertical = false;
                }
            }
        }
    }

    public void ChangeChoosenScreeSideways(GameObject menuToSwitchToo,bool isItLeft) {
        if (isItLeft)
        {
            menuToSwitchToo.transform.position = leftChecker.transform.position;
            isNewOnLeft = true;
        }
        else {
            menuToSwitchToo.transform.position = rightChecker.transform.position;
            isNewOnLeft = false;
        }
        ChoosenScreen = menuToSwitchToo;
        menuToSwitchToo.SetActive(true);
        slideSideway = true;
        areWeSwitching = true;
        
    }


    public void ChangeChoosenScreenVertical(GameObject menuToSwitchToo, bool isItTop)
    {
        if (isItTop)
        {
            menuToSwitchToo.transform.position = topCecker.transform.position;
            isNewOnTop = true;
        }
        else
        {
            menuToSwitchToo.transform.position = botChecker.transform.position;
            isNewOnTop = false;
        }
        ChoosenScreen = menuToSwitchToo;
        menuToSwitchToo.SetActive(true);
        slideVertical = true;
        areWeSwitching = true;
    }

    //Pssst hardcoded area, programmers keep out! :D
    void PreviousMenu()
    {
        MainMenu.SetActive(true);

        switch(curMenu.name){
            case "MainMenu":
                Application.Quit();
                break;

            case "CameraMenu":
                MainMenu.transform.position = leftChecker.transform.position;
                curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(false);
                MainMenu.GetComponent<MenuBehaviour>().SlideToCenter();
                curMenu = MainMenu;
                break;
            case "OptionsMenu":
                MainMenu.transform.position = rightChecker.transform.position;
                curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(true);
                MainMenu.GetComponent<MenuBehaviour>().SlideToCenter();
                curMenu = MainMenu;
                break;
            case "ShowcaseMenu":
                MainMenu.transform.position = botChecker.transform.position;
                curMenu.GetComponent<MenuBehaviour>().SlideVertically(false);
                MainMenu.GetComponent<MenuBehaviour>().SlideToCenter();
                curMenu = MainMenu;
                break;
        }
    }
}
