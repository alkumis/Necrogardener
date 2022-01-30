using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planter : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject _interactText;

    private IPlanterState _state;

    [SerializeField]
    private SpriteRenderer _plantedBone;

    private void Start()
    {
        _state = new NotBoned();
    }

    public void PlantOrGrow(PlayerController player)
    {
        IPlanterState newState = _state.PlantOrGrow(player, this);

        if(newState != null)
        {
            _state = newState;
        }
    }

    public void EnableInteraction(PlayerController player)
    {
        switch(_state)
        {
            case NotBoned:
                if(player.Equippable is Bone)
                {
                    _interactText.SetActive(true);
                    player.Plantable = this;
                }
                break;
        }
    }

    public void DisableInteraction(PlayerController player)
    {
        _interactText.SetActive(false);
        player.Plantable = null;
    }

    public void EquipBone(Sprite equippableSprite)
    {
        _plantedBone.sprite = equippableSprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>().Equals(null))
            return;

        if (collision.GetComponent<PlayerController>().State is Holding)
        {
            EnableInteraction(collision.gameObject.GetComponent<PlayerController>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>().Equals(null))
            return;

        DisableInteraction(collision.gameObject.GetComponent<PlayerController>());
    }    
}
