using TMPro;
using UnityEngine;

public class DocumentManager : MonoBehaviour
{
    public static DocumentManager instance;

    public TMP_Text counterText;
    public TMP_Text objectiveText;

    public int documentCount = 0;
    public int totalDocuments = 3;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        counterText.text = "Dokumen : 0 / 3";
    }

    public void CollectDocument()
    {
        documentCount++;

        counterText.text =
            "Dokumen : " +
            documentCount +
            " / " +
            totalDocuments;

        if (documentCount >= totalDocuments)
        {
            objectiveText.text =
                "Ambil Keycard di dalam Locker";

            // Membuka locker
            LockerManager locker = FindFirstObjectByType<LockerManager>();

            if (locker != null)
            {
                locker.OpenLocker();
            }

            // Menampilkan panel Objective Update
            ObjectiveUI objectiveUI = FindFirstObjectByType<ObjectiveUI>();

            if (objectiveUI != null)
            {
                objectiveUI.ShowDocumentCompletePanel();
            }
        }
    }

    public bool AllDocumentsCollected()
    {
        return documentCount >= totalDocuments;
    }
}