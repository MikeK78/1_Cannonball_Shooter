using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeControl : MonoBehaviour
{

    //[SerializeField] float treshhold = 0.5f;

    public int speed;
    private Vector3 mousePosition;
    private float startOfTargetControlZ;
    //public RectTransform MyParentCanvas;
    //private Vector3 MyParentCanvasPosition;
    public Camera MyCamera;
    public Joystick MyJoystickLeft;
    public Joystick MyJoystickRight;

    // Start is called before the first frame update
    void Start()
    {
        //Get Start coordinates of Target-Control in perspective of the camera (Not the world)
        startOfTargetControlZ = Camera.main.transform.position.z - transform.position.z + 20;
        //private Vector3 MyStartPoint = new Vector3(transform.position.x,  
        //transform.Translate(transform.position.x, transform.position.y , startOfTargetControlZ);
        //MyParentCanvasPosition = Camera.main.ScreenToWorldPoint(MyParentCanvas.transform.position);
        //MyParentCanvasPosition = MyParentCanvas.transform.position;
        //screenBounds = MyCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MyCamera.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVarsStorage.isGameRunning == true)
        {

            // Functional Start
            //// mouse_position is in Screensize
            //Vector3 mouse_position = Input.mousePosition;

            //float x = mouse_position.x;
            //float y = mouse_position.y;

            ////Debug.Log(x);
            ////Debug.Log(y);

            //mouse_position.z = startOfTargetControlZ;

            ////Offset for Mobile Game,(my own thinking ;-)) - mouse is under the crossfade
            //mouse_position.x *= 1.0f;
            //mouse_position.y *= 1.2f;


            //// Set position to initial vector of object
            //Vector3 MyPosition = MyCamera.WorldToScreenPoint(transform.position);
            ////MyPosition.z = startOfTargetControlZ;

            //// Border pixel, where the object should not go in for x + y
            //if (mouse_position.x > 100 && mouse_position.x < (Screen.width - 150))
            //{

            //    MyPosition.x = mouse_position.x;

            //}
            //if (mouse_position.y > 700 && mouse_position.y < (Screen.height - 200))
            //{

            //    MyPosition.y = mouse_position.y;

            //}

            //transform.position = MyCamera.ScreenToWorldPoint(MyPosition);
            // Functional End

            // Joystick Test - Start
            Vector3 MyPosition = MyCamera.WorldToScreenPoint(transform.position);
            MyPosition.z = startOfTargetControlZ;

            if (MyJoystickLeft.Horizontal >= 0.1f || MyJoystickLeft.Horizontal <= -0.2f)
            {
                //Debug.Log(MyPosition.x);
                MyPosition.x += speed * MyJoystickLeft.Horizontal * Time.deltaTime;
                //Debug.Log(MyPosition.x);
            }

            if (MyJoystickLeft.Vertical >= 0.1f || MyJoystickLeft.Vertical <= -0.2f)
            {

                MyPosition.y += speed * MyJoystickLeft.Vertical * Time.deltaTime;

            }

            transform.position = MyCamera.ScreenToWorldPoint(MyPosition);
            // Joystick Test - Ende
        }



    }
}
