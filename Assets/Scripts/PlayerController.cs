using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Vector2 movementVector;
    public IInteractable interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(movementVector.x, movementVector.y, 0));
    }

    public void UpdatedMoveVector(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        movementVector = inputVector * movementSpeed * Time.fixedDeltaTime;
    }
}
