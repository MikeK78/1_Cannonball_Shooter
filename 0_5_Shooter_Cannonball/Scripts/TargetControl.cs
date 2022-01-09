using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControl : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MyMoveVevtor = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            MyMoveVevtor += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MyMoveVevtor += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MyMoveVevtor += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MyMoveVevtor += Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyMoveVevtor += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MyMoveVevtor += Vector3.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyMoveVevtor += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyMoveVevtor += Vector3.right;
        }

        transform.Translate(MyMoveVevtor * speed * Time.deltaTime);

        
    }
}
