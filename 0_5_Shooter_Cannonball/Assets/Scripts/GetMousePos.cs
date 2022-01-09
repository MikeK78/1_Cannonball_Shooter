using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePos : MonoBehaviour
{
    void Update()
    {
        Vector3 mouse_position = Input.mousePosition;

        float x = mouse_position.x;
        float y = mouse_position.y;

        Debug.Log(x);
    }
}
