using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 size = new Vector3(1f, 1f, 1f); // Customize the size of the cube

    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position;
        cube.transform.rotation = transform.rotation;
        cube.transform.localScale = size;
    }
}
