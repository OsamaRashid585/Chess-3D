using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != 7)
        {
            transform.Translate(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != 0)
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z != 7)
        {
            transform.Translate(0, 0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z != 0)
        {
            transform.Translate(0, 0, -1);
        }
    }
}
