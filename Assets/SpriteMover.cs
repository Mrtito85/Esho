using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float movementSpeed = 5f; // Speed at which the sprite moves towards the target position

    private Vector3 targetPosition; // Target position to move the sprite towards
    private bool isMoving = false; // Flag to check if the sprite is currently moving

    private void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButtonDown(0))
        {
            // Get the target position from the mouse pointer click
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;

            // Start moving the sprite towards the target position
            isMoving = true;
        }
#endif

#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Get the target position from the touch position
                targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                targetPosition.z = 0f;

                // Start moving the sprite towards the target position
                isMoving = true;
            }
        }
#endif

        if (isMoving)
        {
            // Calculate the direction from the current position to the target position
            Vector3 direction = targetPosition - transform.position;

            // Check if the sprite has reached the target position
            if (direction.magnitude <= 0.01f)
            {
                // Stop moving the sprite
                isMoving = false;
            }
            else
            {
                // Move the sprite towards the target position using Lerp interpolation
                transform.position = Vector3.Lerp(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            }
        }
    }
}
