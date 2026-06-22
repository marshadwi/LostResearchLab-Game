using UnityEngine;

public class PickupKeycard : MonoBehaviour
{
    public DoorInteract doorInteract;

    private bool playerNear = false;
    private bool keycardTaken = false;

    void Update()
    {
        if (playerNear && !keycardTaken && Input.GetKeyDown(KeyCode.E))
        {
            keycardTaken = true;

            Debug.Log("Keycard diambil");

            // player sekarang punya keycard
            doorInteract.hasKeycard = true;

            // hilangkan keycard
            transform.parent.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            Debug.Log("Tekan E untuk mengambil keycard");
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