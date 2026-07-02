using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractObject : MonoBehaviour
{
public enum ObjectType
{
    OperationTable,
    Cabinet,
    Trolley,
    Keycard,
    ExitDoor,
    Locker
}


public ObjectType objectType;

public static bool hasKeycard = false;

private bool playerNear = false;
private bool collected = false;

void Update()
{
    if (playerNear)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Tombol E ditekan");

            Interact();
        }
    }
}

void Interact()
{
    switch (objectType)
    {
        case ObjectType.OperationTable:

            if (!collected)
            {
                collected = true;
                DocumentManager.instance.CollectDocument();

                Debug.Log("Dokumen ditemukan di Meja Operasi");
            }

            break;

        case ObjectType.Cabinet:

            if (!collected)
            {
                collected = true;
                DocumentManager.instance.CollectDocument();

                Debug.Log("Dokumen ditemukan di Cabinet");
            }

            break;

        case ObjectType.Trolley:

            if (!collected)
            {
                collected = true;
                DocumentManager.instance.CollectDocument();

                Debug.Log("Dokumen ditemukan di Trolley");
            }

            break;

        case ObjectType.Keycard:

            if (!hasKeycard)
            {
                hasKeycard = true;

                Debug.Log("Keycard diperoleh");

                gameObject.SetActive(false);
            }

            break;

        case ObjectType.ExitDoor:

            if (hasKeycard)
            {
                Debug.Log("Access Granted");

                SceneManager.LoadScene("Level2");
            }
            else
            {
                Debug.Log("Access Denied - Cari Keycard");
            }

            break;

    }
}

void OnTriggerEnter(Collider other)
{
    Debug.Log("Ada yang masuk trigger");

    if(other.CompareTag("Player"))
    {
        Debug.Log("Player Masuk");

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
