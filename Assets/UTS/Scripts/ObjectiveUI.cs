using UnityEngine;

public class ObjectiveUI : MonoBehaviour
{
    [Header("Panel Awal")]
    public GameObject objectivePanel;

    [Header("Panel Setelah 3 Dokumen")]
    public GameObject documentCompletePanel;

    public PlayerMovement playerMovement;
    public MouseLook mouseLook;

    private bool objectiveActive = true;

    void Start()
    {
        objectivePanel.SetActive(true);

        if(documentCompletePanel != null)
            documentCompletePanel.SetActive(false);

        playerMovement.enabled = false;
        mouseLook.enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {
        if (!objectiveActive)
            return;

        if (Input.GetAxisRaw("Horizontal") != 0 ||
            Input.GetAxisRaw("Vertical") != 0)
        {
            HideObjective();
        }
    }

    void HideObjective()
    {
        objectiveActive = false;

        objectivePanel.SetActive(false);

        playerMovement.enabled = true;
        mouseLook.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Dipanggil saat dokumen sudah 3
    public void ShowDocumentCompletePanel()
    {
        documentCompletePanel.SetActive(true);

        playerMovement.enabled = false;
        mouseLook.enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    // Dipanggil tombol OK
    public void CloseDocumentCompletePanel()
    {
        documentCompletePanel.SetActive(false);

        playerMovement.enabled = true;
        mouseLook.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1f;
    }
}