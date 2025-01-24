using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 targetPosition;
    private bool isMoving = false;

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        isMoving = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false;
                Debug.Log("Car reached target.");
            }
        }
    }
}
