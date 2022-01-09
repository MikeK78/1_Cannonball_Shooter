using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public BallMachine MyBallMachine;
    public ProgressBar MyProgressBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MyProgressBar.FillUp();
        }

        if (Input.GetMouseButtonUp(0))
        {
            MyBallMachine.Shoot();
            // Set to StartValue
            MyProgressBar.current = MyProgressBar.startvalue;
        }
    }

}
