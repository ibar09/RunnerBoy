using UnityEngine;

public class TouchLook : MonoBehaviour
{
    [HideInInspector]
    public static Vector2 TouchDist;
    
    private GameManager _manager;

    private void Start()
    {
        _manager = GameManager.instace;
    }

    private void Update()
    {
        if (!_manager.mobileControl)
            return;
        TouchInput();
    }

    private void TouchInput()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    //Touch began, save position
                    if (touch.phase == TouchPhase.Began)
                    {
                        TouchDist.x = 0;
                        TouchDist.y = 0;
                    }

                    //Move finger by screen
                    if (touch.phase == TouchPhase.Moved)
                    {
                        TouchDist.x = touch.deltaPosition.x;
                        TouchDist.y = touch.deltaPosition.y;
                    }

                    if (touch.phase == TouchPhase.Stationary)
                    {
                        TouchDist.x = 0;
                        TouchDist.y = 0;
                    }

                    //Touch end
                    if (touch.phase == TouchPhase.Ended)
                    {
                        TouchDist.x = 0;
                        TouchDist.y = 0;
                    }
                }
                else
                {
                    TouchDist.x = 0;
                    TouchDist.y = 0;
                }
            }
        }
    }
}
