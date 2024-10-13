using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb = null;

    public float frontForce = 1000f;    
    public float sideForce = 500f;
    void Update()
    {
        rb.AddForce(0,0,frontForce*Time.deltaTime,ForceMode.VelocityChange);

        if(Input.GetKey("a")){
            rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
         if(rb.position.y< -1f){
            FindObjectOfType<GameManager>().endGame();
        }
    }

}

