using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnInterval = 2f;
    
    void Start()
    {
        Instantiate(this.cloudPrefab, transform.position + Vector3.up * Random.Range(-1f, 1f), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.spawnInterval <= 0)
        {
            SpawnCloud();
            this.spawnInterval = Random.Range(2f, 4f); // Reset the interval to a random value
        }
        else
        {
            this.spawnInterval -= Time.deltaTime; // Decrease the interval timer
        }

    }

    public void SpawnCloud()
    {
        Instantiate(this.cloudPrefab, transform.position + Vector3.up * Random.Range(-1f, 1f), transform.rotation);
    }
}
