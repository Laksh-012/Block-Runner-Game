using UnityEngine;

public class endTrigger : MonoBehaviour {
    
    public GameManager g;
    public PlayerMovement s;
    void OnTriggerEnter(){
        g.completeLevel();
        s.enabled = false;
    }
}