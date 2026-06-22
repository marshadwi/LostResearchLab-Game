using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public DoorController door;

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;

            Debug.Log("Tekan E untuk membuka pintu");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}