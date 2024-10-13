using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{ 
    public Transform player;
    public Vector3 offset = new Vector3(0, 1.85f, -4.97f);

    public void Update() {
        transform.position = player.position + offset;
    }
}
