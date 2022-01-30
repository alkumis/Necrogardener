using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IEquippable
{
    [SerializeField]
    private GameObject _pickUpText;

    [SerializeField]
    private Sprite _equippedItem;

    public Sprite GibEquipSprite { get { return _equippedItem; } }

    public GameObject GibGameobject { get { return this.gameObject; } }

    public void EnableInteraction(PlayerController player)
    {
        _pickUpText.SetActive(true);

        player.Equippable = this;
    }

    public void DisableInteraction(PlayerController player)
    {
        _pickUpText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() == null)
            return;

        if (collision.GetComponent<PlayerController>().State is Regular)
        {
            EnableInteraction(collision.gameObject.GetComponent<PlayerController>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() == null)
            return;

        DisableInteraction(collision.gameObject.GetComponent<PlayerController>());
    }
}
