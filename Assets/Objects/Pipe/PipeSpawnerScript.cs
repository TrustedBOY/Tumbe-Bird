using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer;
    public float spawnRate = 5;
    public float heightOffset = 2;
    void Start()
    {
        timer = 0;
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer >= spawnRate)
        {
            timer = 0;
            spawnPipe();
        } 
        else
        {
            timer += Time.deltaTime;
        }
        
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestPoint , highestPoint) , transform.position.z), transform.rotation);
    }
}
