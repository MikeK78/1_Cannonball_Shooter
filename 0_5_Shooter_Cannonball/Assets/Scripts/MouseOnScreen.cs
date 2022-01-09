using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseOnScreen : MonoBehaviour
{
    public BallMachine MyBallMachine;
    public ProgressBar MyProgressBar;
    private float OldMouseMoveX;
    private float OldMouseMoveY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //MyBallMachine.Shoot();
            // Set to StartValue
            MyProgressBar.current = MyProgressBar.startvalue;
        }


        //if (Input.GetMouseButton(0))
        //{
        //    MyProgressBar.FillUp();
        //}


        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log(Input.mousePosition.x);
        //    //Debug.Log(Input.mousePosition.y);
        //    Debug.Log(OldMouseMoveX);
        //    //Debug.Log(OldMouseMoveY);


        //    if (Input.mousePosition.x > (Input.mousePosition.x - (OldMouseMoveX / 1000)) && Input.mousePosition.x < (Input.mousePosition.x + (OldMouseMoveX / 1000)))
        //    {
        //        MyProgressBar.FillUp();
        //        Debug.Log("Fill up");
        //    }
        //    else
        //    {
        //        MyProgressBar.current = MyProgressBar.startvalue;
        //    }

        //    // Save MouseMove, to check if Progressbar should be filled
        //    OldMouseMoveX = Input.mousePosition.x;
        //    OldMouseMoveY = Input.mousePosition.y;
        //}


    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log(Input.mousePosition.x);
            ////Debug.Log(Input.mousePosition.y);
            //Debug.Log(OldMouseMoveX);
            ////Debug.Log(OldMouseMoveY);


            //if (Input.mousePosition.x > (Input.mousePosition.x - (OldMouseMoveX / 1000)) && Input.mousePosition.x < (Input.mousePosition.x + (OldMouseMoveX / 1000)))
            //{
            //    MyProgressBar.FillUp();
            //    Debug.Log("Fill up");
            //}
            //else
            //{
            //    MyProgressBar.current = MyProgressBar.startvalue;
            //}

            //// Save MouseMove, to check if Progressbar should be filled
            //OldMouseMoveX = Input.mousePosition.x;
            //OldMouseMoveY = Input.mousePosition.y;
        }
    }
}
