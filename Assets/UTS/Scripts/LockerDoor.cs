using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    public Transform doorPivot;
    public float openAngle = 90f;

    private bool isOpen = false;

    public void OpenDoor()
    {
        if (isOpen) return;

        Debug.Log("Locker terbuka");

        doorPivot.localRotation =
            Quaternion.Euler(0, openAngle, 0);

        isOpen = true;
    }
}