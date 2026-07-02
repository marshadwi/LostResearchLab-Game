using UnityEngine;

public class LockerManager : MonoBehaviour
{
    public LockerDoor lockerDoor;
    public GameObject keycard;

    public void OpenLocker()
    {
        if (lockerDoor != null)
        {
            lockerDoor.OpenDoor();
        }

        if (keycard != null)
        {
            keycard.SetActive(true);
        }

        Debug.Log("Locker terbuka, Keycard muncul");
    }
}