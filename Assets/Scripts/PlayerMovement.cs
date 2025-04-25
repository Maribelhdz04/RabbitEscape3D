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
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = (transform.right * h + transform.forward * v).normalized;
        cc.Move(dir * speed * Time.deltaTime);
    }
}
