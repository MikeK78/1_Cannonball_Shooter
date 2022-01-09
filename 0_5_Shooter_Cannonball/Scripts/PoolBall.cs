using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    public int speed;
    private GameObject MyTarget;
    private Vector3 MyTargetPosition;
    void Start()
    {
        //Object will be destroyed after 3 seconds
        Destroy(gameObject, 5);

        MyTarget = GameObject.FindGameObjectWithTag("Crosshair");

        MyTargetPosition = transform.position + (MyTarget.transform.position - transform.position).normalized * 1000.0f; // Ziel liegt hinter dem Fadenkreuz (in der Richtung)

    }

    // Update is called once per frame
    void Update()
    {
        // old
        //transform.Translate(BallMachine.transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);


        // Move to Crossfade (But stops there)

        //This code is called once every frame
        //Lets start by finding the direction between our object and the target position
        //You can find the direction from point A to point B via Vector subtraction
        //Calling transform by itself grabs the transform that is attached to the game object that this script is attached to
        Vector3 directionToMove = MyTargetPosition - transform.position;

        //Now we have the direction, but we need to calculate the distance to move. 
        //We will scale our direction vector to the wanted magnitude        
        directionToMove = directionToMove.normalized * Time.deltaTime * speed;

        //A normalized vector is a vector with length 1
        //Time.deltaTime is the time since Update() was last called. This is used so that we get a constant speed, regardless of frame rate
        //Finish by scaling by our desired movement speed

        float maxDistance = Vector3.Distance(transform.position, MyTargetPosition * 5);
        transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);
        //You don't have to memorize these kinds of functions, Unity Documentation is your friend


    }


}
