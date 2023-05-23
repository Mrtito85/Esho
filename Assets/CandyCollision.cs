using UnityEngine;

public class CandyCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Mouse"))
        {
            Destroy(gameObject);
            
        }
    }

    private void Start()
    {
        
    }
}
