using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour, IEquippable
{
    [SerializeField]
    private GameObject _pickUpText;

    [SerializeField]
    private Sprite _equippedBone;

    [SerializeField]
    private Sprite _planterBone;

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
        if (collision.GetComponent<PlayerController>().Equals(null))
            return;

        if (collision.GetComponent<PlayerController>().State is Regular)
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
