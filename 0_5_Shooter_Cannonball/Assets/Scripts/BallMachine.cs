using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallMachine : MonoBehaviour
{
    
    public GameObject PoolBall;
    public TextMeshProUGUI Score;
    public int intCountScore = 0;
    public TextMeshProUGUI Bullets;
    public int intCountBullet = 100;


    void Start()
    {

        //InvokeRepeating(nameof(Shoot), 0, 2);

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(PoolBall, transform.position, Quaternion.identity, transform);
        //}

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    CancelInvoke(nameof(Shoot));
        //}


    }

    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Shoot();
    //    }

    //}

    public void Shoot()
    {
        if(intCountBullet > 0)
        {
            FindObjectOfType<AudioManager>().Play("CannonShot");
            Instantiate(PoolBall, transform.position, Quaternion.identity, transform);
            intCountBullet -= 1;
            Bullets.text = intCountBullet.ToString();

        }
        else
        {
            // Stop the game and show score
        }

    }

}
