using UnityEngine;

public class FinalObjective : MonoBehaviour
{
    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Data penelitian berhasil diambil");

            Debug.Log("MISSION COMPLETE");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;

            Debug.Log("Tekan E untuk mengambil data penelitian");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}