using UnityEngine;

public class ObjectActivation : MonoBehaviour
{
    public GameObject parentGameObject;

    void Update()
    {
        // Example: Pressing the 'Space' key to toggle activation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle the active state of the parentGameObject
            parentGameObject.SetActive(!parentGameObject.activeSelf);
        }
    }
}
