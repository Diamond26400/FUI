using UnityEngine;

public class Clickswipe : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    private bool isSwiping = false;

    public float swipeThreshold = 10f; // Adjust this value to set the swipe sensitivity
    public LineRenderer lineRenderer;
    public Color swipeColor = Color.green;

    void Start()
    {
        lineRenderer.startColor = swipeColor;
        lineRenderer.endColor = swipeColor;
    }

    void Update()
    {
        CheckForSwipe();
    }

    void CheckForSwipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Input.mousePosition;
            isSwiping = true;
            lineRenderer.positionCount = 1;
            lineRenderer.SetPosition(0, Camera.main.ScreenToWorldPoint(new Vector3(touchStartPos.x, touchStartPos.y, 10f)));
        }

        if (isSwiping)
        {
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f)));
        }

        if (Input.GetMouseButtonUp(0))
        {
            touchEndPos = Input.mousePosition;
            isSwiping = false;

            float swipeDistance = Vector3.Distance(touchStartPos, touchEndPos);

            if (swipeDistance > swipeThreshold)
            {
                Vector3 swipeDirection = (touchEndPos - touchStartPos).normalized;
                HandleSwipe(swipeDirection);
            }

            lineRenderer.positionCount = 0; // Clear the line renderer
        }
    }

    void HandleSwipe(Vector3 direction)
    {
        // Perform actions based on the swipe direction
        // For example, move the player character in the specified direction
        Debug.Log("Swipe Direction: " + direction);

        // Add your logic here to move the game object or perform other actions.
    }
}
