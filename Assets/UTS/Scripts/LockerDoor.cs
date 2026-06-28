using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    public Transform doorPivot;
    public float openAngle = 90f;

    private bool isOpen = false;

    public void Interact()
    {
        if (!DocumentManager.instance.AllDocumentsCollected())
        {
            Debug.Log("Kumpulkan 3 dokumen terlebih dahulu.");
            return;
        }

        if (!isOpen)
        {
            doorPivot.localRotation =
                Quaternion.Euler(0, openAngle, 0);

            isOpen = true;
        }
        else
        {
            doorPivot.localRotation =
                Quaternion.Euler(0, 0, 0);

            isOpen = false;
        }
    }
}