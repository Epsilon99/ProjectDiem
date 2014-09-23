using UnityEngine;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {

    public float speed;
    private GameObject rightChecker;
    private GameObject leftChecker;
    private GameObject midChecker;
    private Transform thisTransform;

	// Use this for initialization
	void Start () {
        thisTransform = transform;
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
        midChecker = GameObject.FindGameObjectWithTag("MidChecker");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SlideToTheSide(bool slideLeft) { 
        float curSpeed;
        Transform curTarget;

        if (slideLeft){
            curSpeed = -speed;
            curTarget = leftChecker.transform;
            while (thisTransform.position.x > curTarget.position.x) {
                thisTransform.Translate(Vector2.right * curSpeed * Time.deltaTime);
            }
            gameObject.SetActive(false);
        }
        else{
            curSpeed = speed;
            curTarget = rightChecker.transform;
            while (thisTransform.position.x < curTarget.position.x)
            {
                thisTransform.Translate(Vector2.right * curSpeed * Time.deltaTime);
            }
            gameObject.SetActive(false);
        }
    }

    public void SlideToCenter(bool slideFromLeft) {
        float curSpeed;
        Transform curTarget = midChecker.transform;

        if (slideFromLeft){
            curSpeed = speed;
            while (thisTransform.position.x < curTarget.position.x) {
                thisTransform.Translate(Vector2.right * curSpeed * Time.deltaTime);
            }
        }
        else{
            curSpeed = -speed;
            while (thisTransform.position.x > curTarget.position.x)
            {
                thisTransform.Translate(Vector2.right * curSpeed * Time.deltaTime);
            }
        }
    }
}
