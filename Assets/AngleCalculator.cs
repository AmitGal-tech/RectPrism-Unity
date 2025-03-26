using UnityEngine;

public class AngleCalculator : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;

    private bool drawRightAngle;

    void Update()
    {
        // Calculate vectors from pointA to pointB and pointA to pointC
        Vector3 vectorAB = pointB.position - pointA.position;
        Vector3 vectorAC = pointC.position - pointA.position;

        // Calculate the angle between vectorAB and vectorAC using the dot product
        float dotProduct = Vector3.Dot(vectorAB, vectorAC);
        float magnitudeAB = vectorAB.magnitude;
        float magnitudeAC = vectorAC.magnitude;

        // Calculate the angle in radians
        float angleInRadians = Mathf.Acos(dotProduct / (magnitudeAB * magnitudeAC));

        // Convert the angle to degrees
        float angleInDegrees = Mathf.Rad2Deg * angleInRadians;

        // Print the angle to the console
        Debug.Log("Angle: " + angleInDegrees);

        // Set the flag to draw the right angle if the calculated angle is approximately 90 degrees
        drawRightAngle = Mathf.Approximately(angleInDegrees, 90f);
    }

    // Draw Gizmos only if the flag is set to true
    private void OnDrawGizmos()
    {
        if (drawRightAngle)
        {
            DrawRightAngleSymbol(pointA.position + (pointB.position - pointA.position).normalized * 0.5f);
        }
    }

    // Draw Gizmos only if the object is selected
    private void OnDrawGizmosSelected()
    {
        OnDrawGizmos();
    }

    // Draw a visual representation of a right angle at the specified position
    private void DrawRightAngleSymbol(Vector3 position)
    {
        Gizmos.color = Color.red;

        float size = 0.2f;
        float offset = size * 0.5f;

        Vector3 p1 = position + new Vector3(-offset, 0, -offset);
        Vector3 p2 = position + new Vector3(offset, 0, -offset);
        Vector3 p3 = position + new Vector3(offset, 0, offset);
        Vector3 p4 = position + new Vector3(-offset, 0, offset);

        Gizmos.DrawLine(p1, p2);
        Gizmos.DrawLine(p2, p3);
        Gizmos.DrawLine(p3, p4);
        Gizmos.DrawLine(p4, p1);
    }
}
