using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public Transform startObject;
    public Transform endObject;

    public float lineWidth = 0.1f; // Width of the line

    private LineRenderer lineRenderer;

    void Start()
    {
        // Create LineRenderer component if not already attached
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }

        // Set up the initial line positions and properties
        UpdateLine();
    }

    void Update()
    {
        // Update the line positions during runtime
        UpdateLine();
    }

    void UpdateLine()
    {
        if (startObject != null && endObject != null && lineRenderer != null)
        {
            // Set the line positions
            lineRenderer.SetPosition(0, startObject.position);
            lineRenderer.SetPosition(1, endObject.position);

            // Set the line color
            lineRenderer.startColor = Color.green;
            lineRenderer.endColor = Color.green;

            // Set the line width
            lineRenderer.startWidth = lineWidth;
            lineRenderer.endWidth = lineWidth;

            // You can customize other LineRenderer properties here, such as material, etc.
        }
    }
}