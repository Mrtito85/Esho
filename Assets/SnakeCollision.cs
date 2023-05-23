using UnityEngine;
using UnityEngine.UI;

public class SnakeCollision : MonoBehaviour
{

    public static bool check = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mouse"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

       

    }
}
