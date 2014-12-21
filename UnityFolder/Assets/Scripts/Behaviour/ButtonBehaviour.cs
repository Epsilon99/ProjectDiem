using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {

    public GameObject SceneToGoTo;

    public bool SlideSideways;
    public bool SlideFromLeft;
    public bool SlideFromTop;

    private GameObject MenuHandlerGO;


    void Awake() {
        MenuHandlerGO = GameObject.FindGameObjectWithTag("MenuHandler");
    }

    void OnPress(bool isDown)
    {
        if (isDown && MenuHandlerGO.GetComponent<GlobalCooldown>().isCooldownOff == true)
        {
            if (SlideSideways)
                MenuHandlerGO.GetComponent<MenuHandler>().ChangeChoosenScreeSideways(SceneToGoTo, SlideFromLeft);
            else
                MenuHandlerGO.GetComponent<MenuHandler>().ChangeChoosenScreenVertical(SceneToGoTo, SlideFromTop);

            MenuHandlerGO.GetComponent<GlobalCooldown>().StartCooldown();
        }
            
    }

}
