using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCuboid : MonoBehaviour
{
    public float speed = 50f;
    public GameObject cuboidPrefab;

    private float x;
    private float y;
    private float z;

    void Start()
    {
        StartCoroutine(InstantiateCuboids());
    }

    IEnumerator InstantiateCuboids()
    {
        for (int x = -5; x <= 5; x++)
        {
            for (int y = -5; y <= 5; y++)
            {
                for (int z = -5; z <= 5; z++)
                {
                    Vector3 position = new Vector3(x, y, z);
                    Quaternion rotation = Quaternion.identity;
                    GameObject newCuboid = Instantiate(cuboidPrefab, position, rotation);
                    newCuboid.transform.parent = gameObject.transform;
                    newCuboid.transform.localScale = new Vector3(1, 1, 1);

                    // Let the system rest for a while
                    yield return new WaitForSeconds(0.001f);
                }
            }
        }
    }

    void Update()
    {
        x += speed * Time.deltaTime;
        y += speed * Time.deltaTime;
        z += speed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}