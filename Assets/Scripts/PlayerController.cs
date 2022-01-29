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
    IPlayerState state;

    [SerializeField]
    private SpriteRenderer equippedItem;

    // Start is called before the first frame update
    void Start()
    {
        state = new RegularState();
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

    public void EquipItem(Sprite equippableSprite)
    {
        equippedItem.sprite = equippableSprite;
    }

    public void PickOrDrop(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed && interactable != null)
        {
            state.PickOrDrop(this);
        }
    }    
}
