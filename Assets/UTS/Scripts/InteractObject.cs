using UnityEngine;

public class InteractObject : MonoBehaviour
{
    public enum ObjectType
    {
        OperationTable,
        Locker,
        WorkDesk,
        Cabinet,
        Keycard,
        ExitDoor
    }

    public ObjectType objectType;

    public static bool hasKeycard = false;

    bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        switch(objectType)
        {
            case ObjectType.OperationTable:
                Debug.Log("Dokumen 1 ditemukan");
                break;

            case ObjectType.Locker:
                Debug.Log("Dokumen 2 ditemukan");
                break;

            case ObjectType.WorkDesk:
                Debug.Log("Dokumen 3 ditemukan");
                break;

            case ObjectType.Cabinet:
                Debug.Log("Cabinet dibuka");
                break;

            case ObjectType.Keycard:
                hasKeycard = true;
                Debug.Log("Keycard diperoleh");
                gameObject.SetActive(false);
                break;

            case ObjectType.ExitDoor:

                if(hasKeycard)
                {
                    Debug.Log("Access Granted");
                }
                else
                {
                    Debug.Log("Access Denied");
                }

                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}