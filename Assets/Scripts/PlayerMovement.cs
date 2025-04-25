using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Movement speed in units per second")]
    public float speed = 5f;
    private CharacterController cc;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Read input axes
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Build a movement vector relative to the player’s facing
        Vector3 dir = (transform.right * h + transform.forward * v).normalized;

        // Move the character controller
        cc.Move(dir * speed * Time.deltaTime);
    }
}
