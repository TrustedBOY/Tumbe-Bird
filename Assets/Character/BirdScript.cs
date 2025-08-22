using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigid;
    public float jumpForce = 2;
    public bool isAlive = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            birdRigid.linearVelocity = new Vector2(birdRigid.linearVelocity.x, jumpForce);
        }
    }
}
