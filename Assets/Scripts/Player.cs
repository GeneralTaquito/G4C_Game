using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public Rigidbody2D RB;
    public float SprintSpeed = 3.5f;
    public float Walkspeed = 2.5f;
    void Update()
    {
        // The basic movement code for everything :p
        Vector2 vel = new Vector2(0,0);
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -speed;
        }


        // SPRINTING

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = SprintSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = Walkspeed;
        }

            RB.linearVelocity = vel;
    }
        
}
