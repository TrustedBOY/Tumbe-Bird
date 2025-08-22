using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeLimit = -10.5f;

    public float pipeSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (transform.position.x <= pipeLimit)
        {
            Destroy(gameObject);
        }

        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
    }
}
