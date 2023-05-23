using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    
    public GameObject candyPrefab; // Prefab of the candy sprite
    public Camera mainCamera; // Reference to the main camera
    public float spawnInterval = 5f; // Time interval between candy spawns
    public float spawnRange = 5f; // Range within the camera's view to spawn candies

    private float timer = 0f; // Timer to track the spawn interval

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnCandy();
            timer = 0f;
        }
    }

    public void SpawnCandy()
    {
        // Calculate the camera bounds within the given range
        float cameraHeight = mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;
        Vector3 cameraPosition = mainCamera.transform.position;

        float minX = cameraPosition.x - cameraWidth + spawnRange;
        float maxX = cameraPosition.x + cameraWidth - spawnRange;
        float minY = cameraPosition.y - cameraHeight + spawnRange;
        float maxY = cameraPosition.y + cameraHeight - spawnRange;

        // Generate a random position within the camera's view and spawn the candy
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        Instantiate(candyPrefab, spawnPosition, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Method Invoke");
        if (collision.gameObject.CompareTag("Mouse"))
        {
            Destroy(gameObject);
            Debug.Log("ON Collision Enter");
        }
    }
}
