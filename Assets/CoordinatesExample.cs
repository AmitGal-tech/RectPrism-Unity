using UnityEngine;

public class CoordinatesExample : MonoBehaviour
{
    // Declare a Vector3 variable to store coordinates
    public Vector3 coordinates;

    void Start()
    {
        // Assign values to the coordinates
        coordinates = new Vector3(1.0f, 2.0f, 3.0f);

        // Access individual components of the vector
        float x = coordinates.x;
        float y = coordinates.y;
        float z = coordinates.z;

        // Output the coordinates to the console
        Debug.Log("Coordinates: " + coordinates);
        Debug.Log("X: " + x + ", Y: " + y + ", Z: " + z);
    }
}
