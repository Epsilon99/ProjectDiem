using UnityEngine;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {

    public float speed;
    private GameObject rightChecker;
    private GameObject leftChecker;
    private GameObject midChecker;
    private GameObject botChecker;
    private GameObject topCecker;
    private Transform thisTransform;
    private Transform curTarget;

    private bool areWeMoving;

    public bool isThisFirstScreen;


	// Use this for initialization
    void Awake() {
        thisTransform = transform;
        rightChecker = GameObject.FindGameObjectWithTag("RightChecker");
        leftChecker = GameObject.FindGameObjectWithTag("LeftChecker");
        midChecker = GameObject.FindGameObjectWithTag("MidChecker");
        botChecker = GameObject.FindGameObjectWithTag("BotChecker");
        topCecker = GameObject.FindGameObjectWithTag("TopChecker");
    }

	void Start () {
        
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
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, true));

        }
        else{
            curSpeed = speed;
            curTarget = rightChecker.transform;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, true));
        }
    }

    public void SlideToCenter() {
        float curSpeed = speed;
        Transform curTarget = midChecker.transform;

        areWeMoving = true;
        StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, false));
        
    }

    public void SlideVertically(bool slideDown) {
        float curSpeed;
        Transform curTarget;

        if (slideDown)
        {
            curSpeed = speed;
            curTarget = botChecker.transform;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget,  true));

        }
        else
        {
            curSpeed = speed;
            curTarget = topCecker.transform;
            StartCoroutine(SlideAndDeactivate(curSpeed, curTarget, true));
        }
    }

    IEnumerator SlideAndDeactivate(float movementSpeed,Transform targetToMoveTo,bool deactive){

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
