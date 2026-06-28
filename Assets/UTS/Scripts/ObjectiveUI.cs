using UnityEngine;

public class ObjectiveUI : MonoBehaviour
{
    public GameObject objectivePanel;

    bool objectiveHidden = false;

    void Update()
    {
        if (!objectiveHidden)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            if (horizontal != 0 || vertical != 0)
            {
                objectivePanel.SetActive(false);
                objectiveHidden = true;
            }
        }
    }
}