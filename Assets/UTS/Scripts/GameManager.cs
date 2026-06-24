using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int documentsFound = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddDocument()
    {
        documentsFound++;

        Debug.Log("Dokumen: " + documentsFound);

        if(documentsFound == 3)
        {
            Debug.Log("Kode Akses: 274");
        }
    }
}