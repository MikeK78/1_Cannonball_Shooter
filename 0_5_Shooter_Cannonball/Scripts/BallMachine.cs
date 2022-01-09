using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMachine : MonoBehaviour
{
    
    public GameObject PoolBall;

    void Start()
    {

        InvokeRepeating(nameof(Shoot), 0, 2);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PoolBall, transform.position, Quaternion.identity, transform);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            CancelInvoke(nameof(Shoot));
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            //Transform = Dieses Objekt (BallMachine)
            Instantiate(PoolBall, transform.position, Quaternion.identity, transform);
        }

    }

    public void Shoot()
    {
        //Transform = Dieses Objekt (BallMachine)
        Instantiate(PoolBall, transform.position, Quaternion.identity, transform);
    }

}
