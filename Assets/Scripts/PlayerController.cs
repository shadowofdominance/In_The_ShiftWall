using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset InputActions;

    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction sprintAction;

    public float moveSpeed;
    public float jumpSpeed;
    public float rotateSpeed;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputActions.FindActionMap("Player").FindAction("Move");
        jumpAction = InputActions.FindActionMap("Player").FindAction("Jump");
    }

    private void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        float horizontalInput = moveInput.x;
        float verticalInput = moveInput.y;

        // Forward/backward movement (W/S)
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);

        // Left/right movement (A/D)
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
    }
}
