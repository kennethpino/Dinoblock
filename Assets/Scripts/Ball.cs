using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float xDirection = 2f;
    [SerializeField] private float yDirection = 15f;
    [SerializeField] private Paddle paddle;
    private Vector2 ballToPaddleOffset;
    private bool isBallLocked = true;

    void Start()
    {
        ballToPaddleOffset = transform.position - paddle.transform.position;
    }

    void Update()
    {
        if (isBallLocked)
        {
            LockBallOnPaddle();
            LaunchOnClick();
        }
    }

    private void LaunchOnClick()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xDirection, yDirection);
            isBallLocked = false;
        }
    }

    private void LockBallOnPaddle()
    {
        transform.position = new Vector2(paddle.transform.position.x + ballToPaddleOffset.x, paddle.transform.position.y + ballToPaddleOffset.y);
    }
}
