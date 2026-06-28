using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public CharacterController controller;
    public float moveSpeed = 5f;

    void Update()
    {
        // Input WASD
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Arah gerakan mengikuti arah player
        Vector3 move =
            transform.right * horizontal +
            transform.forward * vertical;

        // Gerakkan player
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}

