using UnityEngine;
using System.Collections;

public class SlideshowButtonBehaviour : MonoBehaviour {

    private GameObject SlideshowHandlerGO;
    private GameObject MenuHandlerGO;

    public bool SlideFromLeft;

    void Awake()
    {
        SlideshowHandlerGO = GameObject.FindGameObjectWithTag("SlideshowHandler");
        MenuHandlerGO = GameObject.FindGameObjectWithTag("MenuHandler");
    }

    void OnPress(bool isDown)
    {
        if (isDown && MenuHandlerGO.GetComponent<GlobalCooldown>().isCooldownOff == true)
        {
                SlideshowHandlerGO.GetComponent<SlideshowHandler>().ChangeChoosenImageSideways(SlideFromLeft);
                MenuHandlerGO.GetComponent<GlobalCooldown>().StartCooldown();
        }

    }
}
