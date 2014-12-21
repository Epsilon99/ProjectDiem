using UnityEngine;
using System.Collections;

public class ToggleButtonBehaviour : MonoBehaviour {

    public GameObject GameobjectToToggle;

    void OnPress(bool isDown) {
        if (isDown) {
            if (GameobjectToToggle.active == true)
            {
                GameobjectToToggle.active = false;
            }
            else
            {
                GameobjectToToggle.active = true;
            }
        }
    }
}
