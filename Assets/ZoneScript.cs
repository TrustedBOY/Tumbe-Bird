using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    public GameObject bird;
    public LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(bird);
        logic.gameOver();


    }
}
