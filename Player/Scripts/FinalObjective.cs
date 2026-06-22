using UnityEngine;

public class FinalObjective : MonoBehaviour
{
    bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Data berhasil diambil");
            Debug.Log("MISSION COMPLETE");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;

            Debug.Log("Player dekat terminal");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;

            Debug.Log("Player menjauh");
        }
    }
}