using UnityEngine;
using System.Collections;

public class CameraButtonstateHandler : MonoBehaviour {

    public GameObject TakePictureState;
    public GameObject ReviewPictureState;

    private bool takingPicture = true;

    public void SwitchButtons() {
        if (takingPicture) 
        {
            TakePictureState.SetActive(false);
            ReviewPictureState.SetActive(true);
            takingPicture = !takingPicture;
        }

        else
        {
            ReviewPictureState.SetActive(false);
            TakePictureState.SetActive(true);
            takingPicture = !takingPicture;
        }
    }
}
