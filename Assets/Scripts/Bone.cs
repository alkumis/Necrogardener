using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject _pickUpText;

    [SerializeField]
    private Sprite _equippedBone;

    private Sprite _planterBone;

    public void EnableInteraction(PlayerController player)
    {
        _pickUpText.SetActive(true);
        player.Interactable = this;
    }

    public void DisableInteraction(PlayerController player)
    {
        _pickUpText.SetActive(false);

        if (player.Interactable == this)
        {
            player.Interactable = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>().Equals(null))
            return;

        IPlayerState playerState = collision.GetComponent<PlayerController>().State;

        if (playerState is Regular)
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

    public Sprite GibEquipSprite()
    {
        return _equippedBone;
    }

    public Sprite GibPlanterSprite()
    {
        return _planterBone;
    }

    public GameObject GibGameobject()
    {
        return this.gameObject;
    }
}
