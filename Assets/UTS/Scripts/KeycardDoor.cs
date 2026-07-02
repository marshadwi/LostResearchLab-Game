using UnityEngine;

public class KeycardDoor : MonoBehaviour
{
    public DoorController door;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (Inventory.hasKeycard)
        {
            Debug.Log("Keycard ditemukan");

            door.OpenDoor();
        }
        else
        {
            Debug.Log("Butuh Keycard");
        }
    }
}