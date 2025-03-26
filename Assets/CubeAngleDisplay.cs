using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAngles : MonoBehaviour
{
    private float rotationIncrement = 5f;
    private Vector3 rotationAngles;

    private void Start()
    {
        rotationAngles = transform.eulerAngles;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotationAngles.x += rotationIncrement;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rotationAngles.x -= rotationIncrement;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotationAngles.y -= rotationIncrement;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotationAngles.y += rotationIncrement;
        }

    }
}

