using UnityEngine;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {

    public float speed;
    private GameObject rightChecker;
    private GameObject leftChecker;
    public GameObject midChecker;
    private Transform thisTransform;
    private Transform curTarget;

    private bool areWeMoving;

    public bool isThisFirstScreen;

	// Use this for initialization
    void Awake() {
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
        midChecker = GameObject.FindGameObjectWithTag("MidChecker");
    }

	void Start () {
        thisTransform = transform;
        if (!isThisFirstScreen)
            gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SlideToTheSide(bool slideLeft) { 
        float curSpeed;
        Transform curTarget;

        if (slideLeft){
            curSpeed = speed;
            curTarget = leftChecker.transform;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, true, true));

        }
        else{
            curSpeed = speed;
            curTarget = rightChecker.transform;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, false, true));
        }
    }

    public void SlideToCenter(bool slideFromLeft) {
        float curSpeed;
        Transform curTarget = midChecker.transform;

        if (slideFromLeft){
            curSpeed = speed;
            areWeMoving = true;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, false, false));
        }
        else{
            curSpeed = speed;
            areWeMoving = true;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, true, false));
        }
    }

    IEnumerator SlideAndDeactivate(float movementSpeed,Transform targetToMoveTo,bool slideLeft,bool deactive){

        Vector2 startPosition = thisTransform.position;
        float i = 0.0f;
        float rate = 1.0f / movementSpeed;

        while (i < 1.0)
        {
            yield return new WaitForEndOfFrame();
            i = i + (Time.deltaTime * rate);
            thisTransform.position = Vector2.Lerp(startPosition, targetToMoveTo.position, i);
        }

        if(deactive)
            gameObject.SetActive(false);

        curTarget = null;
        areWeMoving = false;

    }
}
