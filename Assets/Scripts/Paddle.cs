using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenSizeInUnitsX = 16f;
    [SerializeField] private float minClamp = 1f;
    [SerializeField] private float maxClamp = 16f;

    void Update()
    {
        float mouseXPos = Input.mousePosition.x / Screen.width * screenSizeInUnitsX;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXPos, minClamp, maxClamp);
        transform.position = paddlePos;
    }
}
    