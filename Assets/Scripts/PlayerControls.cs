using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class PlayerControls : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 offset;

<<<<<<< HEAD
    private float maxLeft;
    private float maxRight;

=======

    private float maxLeft;
    private float maxRight;
    private float maxDown;
    private float maxUp;
>>>>>>> origin/main
    void Start()
    {
        mainCam = Camera.main;

        StartCoroutine(SetBoundaries());
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.isPaused == false){
             if (Touch.fingers[0].isActive)
             {
                 Touch myTouch = Touch.activeTouches[0];
                 Vector3 touchPos = myTouch.screenPosition;
                 touchPos = Camera.main.ScreenToWorldPoint(touchPos);
        
                 if (Touch.activeTouches[0].phase == TouchPhase.Began)
                 {
                     offset = touchPos - transform.position;
                 }
<<<<<<< HEAD
                 if (Touch.activeTouches[0].phase == TouchPhase.Moved || Touch.activeTouches[0].phase == TouchPhase.Stationary)
                 {
                     transform.position = new Vector3(touchPos.x - offset.x, transform.position.y, 0);
                 }
                 transform.position = new Vector3(Mathf.Clamp(transform.position.x, maxLeft, maxRight), transform.position.y, 0);
=======
                 if (Touch.activeTouches[0].phase == TouchPhase.Moved)
                 {
                     transform.position = new Vector3(touchPos.x-offset.x, touchPos.y-offset.y, 0);
                 }
                 if (Touch.activeTouches[0].phase == TouchPhase.Stationary)
                 {
                     transform.position = new Vector3(touchPos.x - offset.x, touchPos.y - offset.y, 0);
                 }
                 transform.position=new Vector3(Mathf.Clamp(transform.position.x, maxLeft, maxRight), Mathf.Clamp(transform.position.y, maxDown, maxUp), 0);
>>>>>>> origin/main
             }
        }
    }

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }

    private IEnumerator SetBoundaries()
    {
        yield return new WaitForSeconds(0.4f);

        maxLeft = mainCam.ViewportToWorldPoint(new Vector2(0.15f, 0)).x;
        maxRight = mainCam.ViewportToWorldPoint(new Vector2(0.85f, 0)).x;
<<<<<<< HEAD
=======

        maxDown = mainCam.ViewportToWorldPoint(new Vector2(0, 0.08f)).y;
        maxUp = mainCam.ViewportToWorldPoint(new Vector2(0, 0.6f)).y;
>>>>>>> origin/main
    }
}
