using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform leftDoor;
    public Transform rightDoor;

    public float openDistance = 2f;
    public float speed = 2f;

    private Vector3 leftClosedPos;
    private Vector3 rightClosedPos;

    private Vector3 leftOpenPos;
    private Vector3 rightOpenPos;

    private bool isOpen = false;

    void Start()
    {
        leftClosedPos = leftDoor.localPosition;
        rightClosedPos = rightDoor.localPosition;

        // kiri geser ke kiri
        leftOpenPos = leftClosedPos + Vector3.left * openDistance;

        // kanan geser ke kanan
        rightOpenPos = rightClosedPos + Vector3.right * openDistance;
    }

    void Update()
    {
        if (isOpen)
        {
            leftDoor.localPosition = Vector3.Lerp(
                leftDoor.localPosition,
                leftOpenPos,
                Time.deltaTime * speed
            );

            rightDoor.localPosition = Vector3.Lerp(
                rightDoor.localPosition,
                rightOpenPos,
                Time.deltaTime * speed
            );
        }
    }

    public void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Pintu terbuka");
    }
}