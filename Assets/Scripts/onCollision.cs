using UnityEngine;

public class onCollision : MonoBehaviour
{
    public PlayerMovement s ;


    public void OnCollisionEnter(Collision collision){
        if (collision.collider.tag == "Objects" || collision.collider.tag == "Finish")
        {
            s.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
    }

    
}
