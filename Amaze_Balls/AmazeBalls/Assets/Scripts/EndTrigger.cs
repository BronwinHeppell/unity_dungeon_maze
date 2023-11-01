using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager manager;
    public PlayerMovement movement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            movement.enabled = false;
            manager.CompleteLevel();
        }

    }
}
