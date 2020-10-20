using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    public Object _gameOverScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(_gameOverScene.name);
    }
}
