using UnityEngine;

public class KeycardDoor : MonoBehaviour
{
    public DoorController door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Inventory.hasKeycard)
            {
                door.OpenDoor();
                Debug.Log("Pintu terbuka");
            }
            else
            {
                Debug.Log("Butuh Keycard");
            }
        }
    }
}