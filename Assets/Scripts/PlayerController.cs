using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;
    private Vector2 _movementVector;

    public IEquippable Equippable;
    [HideInInspector]
    public Planter Plantable;
    private IPlayerState _state;

    public IPlayerState State
    {
        get { return _state; }
    }

    [SerializeField]
    private SpriteRenderer _equippedItem;

    [HideInInspector]
    public Sprite PlanterBone;

    // Start is called before the first frame update
    void Start()
    {
        _state = new Regular();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(_movementVector.x, _movementVector.y, 0));
    }

    public void UpdatedMoveVector(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        _movementVector = inputVector * _movementSpeed * Time.fixedDeltaTime;
    }

    public void EquipItem(Sprite equippableSprite)
    {
        _equippedItem.sprite = equippableSprite;
    }

    public void UnequipItem()
    {
        _equippedItem.sprite = null;
        _state = new Regular();
    }

    public void PickOrDrop(InputAction.CallbackContext context)
    {
        if ((context.phase == InputActionPhase.Performed) && (Equippable != null))
        {
            IPlayerState newState = _state.PickOrDrop(this);

            if(newState != null)
            {
                _state = newState;
            }
        }
    }

    public void PlantOrGrow(InputAction.CallbackContext context)
    {
        if ((context.phase == InputActionPhase.Performed) && (Plantable != null))
        {
            Debug.Log("Plant or Grow being called at player");
            Plantable.PlantOrGrow(this);
        }
    }
}
