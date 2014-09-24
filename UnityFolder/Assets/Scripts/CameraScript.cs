using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public Texture defaultTexture;
    public WebCamDevice[] devices;
    public WebCamTexture webcamTexture;


    private string directory;
    int captureCounter = 0;

    void Awake() {
        directory = Application.persistentDataPath + "/pictures";
    }

    void OnEnable() {
        if (webcamTexture != null)
        {
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }

    }

    void OnDisable() {

        webcamTexture.Stop();
        renderer.material.mainTexture = defaultTexture;
    }

	// Use this for initialization
	void Start () {
        devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture();

        if (devices.Length > 0)
        {
            webcamTexture.deviceName = devices[0].name;
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }
	}


    public void TakeSnapshot()
    {
        Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height);
        snap.SetPixels(webcamTexture.GetPixels());
        snap.Apply();

        System.IO.File.WriteAllBytes(directory + "YourPicture" + captureCounter + ".png", snap.EncodeToPNG());
        captureCounter++;
    }
}
