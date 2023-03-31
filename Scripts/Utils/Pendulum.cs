using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    public float leftAngleLimit;
    public float rightAngleLimit;

    private int speedFactor;

    private bool isMovingClockwise = true;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        ChangeDirection();
        speedFactor = isMovingClockwise ? 1 : -1;
        rb.angularVelocity = speed * speedFactor;
    }

    public void ChangeDirection()
    {
        if (transform.rotation.z > Quaternion.Euler(0,0, rightAngleLimit).z)
        {
            isMovingClockwise = false;
        }
        if (transform.rotation.z < Quaternion.Euler(0,0, leftAngleLimit).z)
        {
            isMovingClockwise = true;
        }
    }
}
