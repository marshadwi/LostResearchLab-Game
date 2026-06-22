using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.localRotation;

        openRotation = closedRotation * Quaternion.Euler(0, 90, 0);
    }

    public void OpenDoor()
    {
        if (!isOpen)
        {
            transform.localRotation = openRotation;

            isOpen = true;
        }
    }
}