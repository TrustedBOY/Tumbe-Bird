using UnityEngine;

public class CloudScript : MonoBehaviour
{
    private LogicScript logic;
    public float cloudSpeed;
    public float cloudDepth;
    public float cloudLimit = 10.5f;
    void Start()
    {
        this.cloudDepth = Random.Range(300, 600) / 100f;
        this.cloudSpeed = cloudDepth / 2;
        this.logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    void Update()
    {

        if (this.transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
        transform.position = transform.position + (Vector3.left * this.cloudSpeed) * Time.deltaTime;
    }
}
