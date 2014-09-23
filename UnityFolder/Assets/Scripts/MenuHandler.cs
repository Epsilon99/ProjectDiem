using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {

    public GameObject curMenu;

    public GameObject ChoosenScreen;

    private bool areWeSwitching;
    private bool isNewOnLeft;

    private GameObject leftChecker;
    private GameObject rightChecker;


    public GameObject Menu2;
    public GameObject Menu3;

	// Use this for initialization
	void Start () {
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            ChangeChoosenSreen(Menu2,true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)&& Menu3 != null) {
            ChangeChoosenSreen(Menu3, false);
        }

        Controls();
        
	}

    void Controls() {

        if (areWeSwitching && ChoosenScreen != null) {
            if (isNewOnLeft)
            {
                curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(false);
                ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter(true);
                Menu3 = curMenu;
                curMenu = ChoosenScreen;
                areWeSwitching = false;
                ChoosenScreen = null;
            }
            else {
                curMenu.GetComponent<MenuBehaviour>().SlideToTheSide(true);
                ChoosenScreen.GetComponent<MenuBehaviour>().SlideToCenter(false);
                Menu3 = curMenu;
                curMenu = ChoosenScreen;
                areWeSwitching = false;
                ChoosenScreen = null;
            }
        }
    }

    public void ChangeChoosenSreen(GameObject menuToSwitchToo,bool isItLeft) {
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
        areWeSwitching = true;
    }
}
