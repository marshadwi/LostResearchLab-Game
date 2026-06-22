using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public DoorController doorController;

    public bool hasKeycard = false;

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (hasKeycard)
            {
                doorController.OpenDoor();
                Debug.Log("Pintu terbuka");
            }
            else
            {
                Debug.Log("Butuh keycard");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            Debug.Log("Tekan E untuk membuka pintu");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}