using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenSizeInUnitsX = 16f;

    void Update()
    {
        float xPos = Input.mousePosition.x / Screen.width * screenSizeInUnitsX;
        Vector2 paddlePos = new Vector2(xPos, transform.position.y);
        transform.position = paddlePos;
    }
}
