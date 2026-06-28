using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(
                transform.position,
                transform.forward
            );

            RaycastHit hit;

            if (
                Physics.Raycast(
                    ray,
                    out hit,
                    interactDistance
                )
            )
            {
                LockerDoor locker =
                    hit.collider.GetComponent<LockerDoor>();

                if (locker != null)
                {
                    locker.Interact();
                }
            }
        }
    }
}