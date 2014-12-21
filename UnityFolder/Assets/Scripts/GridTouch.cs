using UnityEngine;
using System.Collections;
using System.IO;

public class GridTouch : MonoBehaviour {

    public GameObject ImageField;
    public GameObject SceneToGoTo;
    private GameObject MenuHandlerGO;
    private GameObject SlideshowHandlerGO;

	// Use this for initialization
	void Start () {
        MenuHandlerGO = GameObject.FindGameObjectWithTag("MenuHandler");
        SlideshowHandlerGO = GameObject.FindGameObjectWithTag("SlideshowHandler");
	}
	
	// Update is called once per frame
	void Update () {
        Controls();
	}

    void Controls() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Thumbnail")
            {
                if (MenuHandlerGO.GetComponent<GlobalCooldown>().isCooldownOff == true)
                {
                    string imgPath = hit.collider.gameObject.GetComponent<Thumbnail>().ImagePath;
                    var bytes = File.ReadAllBytes(imgPath);
                    Texture2D imgTexture = new Texture2D((int)ImageField.renderer.bounds.size.x, (int)ImageField.renderer.bounds.size.y);
                    imgTexture.LoadImage(bytes);
                    ImageField.renderer.material.mainTexture = imgTexture;
                    SlideshowHandlerGO.GetComponent<SlideshowHandler>().CurImageNumber = hit.collider.GetComponent<Thumbnail>().ImageNumber;
                    MenuHandlerGO.GetComponent<MenuHandler>().ChangeChoosenScreenVertical(SceneToGoTo, true);
                    MenuHandlerGO.GetComponent<GlobalCooldown>().StartCooldown();
                }
            }
        }

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Thumbnail")
            {
                if (MenuHandlerGO.GetComponent<GlobalCooldown>().isCooldownOff == true)
                {
                    string imgPath = hit.collider.gameObject.GetComponent<Thumbnail>().ImagePath;
                    var bytes = File.ReadAllBytes(imgPath);
                    Texture2D imgTexture = new Texture2D((int)ImageField.renderer.bounds.size.x, (int)ImageField.renderer.bounds.size.y);
                    imgTexture.LoadImage(bytes);
                    ImageField.renderer.material.mainTexture = imgTexture;
                    SlideshowHandlerGO.GetComponent<SlideshowHandler>().CurImageNumber = hit.collider.GetComponent<Thumbnail>().ImageNumber;
                    MenuHandlerGO.GetComponent<MenuHandler>().ChangeChoosenScreenVertical(SceneToGoTo, true);
                    MenuHandlerGO.GetComponent<GlobalCooldown>().StartCooldown();
                }
            }
        }


    }
}
