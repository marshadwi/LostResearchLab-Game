using UnityEngine;

public class OpenCabinet : MonoBehaviour
{
    public Transform door;

    bool playerNear = false;
    bool isOpen = false;

    Quaternion closedRotation;
    Quaternion openRotation;

    void Start()
    {
        closedRotation = door.rotation;

        openRotation = closedRotation * Quaternion.Euler(0f, -90f, 0f);
    }

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (!isOpen)
            {
                door.rotation = openRotation;

                isOpen = true;

                Debug.Log("Lemari dibuka");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
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