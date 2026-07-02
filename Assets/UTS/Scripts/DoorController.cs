using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door;
    public float openAngle = 90f;

    private bool opened = false;

    public void OpenDoor()
    {
        if (opened) return;

        door.localRotation = Quaternion.Euler(0, openAngle, 0);

        opened = true;

        Debug.Log("Door Open");
    }
}