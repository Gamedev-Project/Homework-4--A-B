using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWorldMover : MonoBehaviour
{
    float left,right,up,down;
    void Start()
    {
        right = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x;
        down = Camera.main.ScreenToWorldPoint(new Vector3()).y;
        left = Camera.main.ScreenToWorldPoint(new Vector3()).x;
        up = Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y;
    }

    void Update()
    {
        if (transform.position.y >= up)
        {
            transform.position = new Vector3(transform.position.x, down, 0f);
        }
        else if (transform.position.y <= down)
        {
            transform.position = new Vector3(transform.position.x, up, 0f);
        }
        else if (transform.position.x >= right)
        {
            transform.position = new Vector3(left, transform.position.y, 0f);
        }
        else if (transform.position.x <= left)
        {
            transform.position = new Vector3(right, transform.position.y, 0f);
        }
    }
}
