using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {

    public GameObject SceneToGoTo;
    public bool SlideFromLeft;
    private GameObject MenuHandlerGO;

    void Awake() {
        MenuHandlerGO = GameObject.FindGameObjectWithTag("MenuHandler");
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnPress(bool isDown)
    {
        if (isDown) {
                MenuHandlerGO.GetComponent<MenuHandler>().ChangeChoosenSreen(SceneToGoTo, SlideFromLeft);
        }
            
    }
}
