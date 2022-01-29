using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject pickUpText;

    public Sprite equippedBone;

    public void DisableInteraction(PlayerController player)
    {
        pickUpText.SetActive(false);
        player.interactable = null;
    }

    public void EnableInteraction(PlayerController player)
    {
        pickUpText.SetActive(true);
        player.interactable = this;
    }

    //public Sprite GibSprite()
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void Interact()
    //{
    //    throw new System.NotImplementedException();
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>().Equals(null))
            return;

        EnableInteraction(collision.gameObject.GetComponent<PlayerController>());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>().Equals(null))
            return;

        DisableInteraction(collision.gameObject.GetComponent<PlayerController>());
    }

    public Sprite GibSprite()
    {
        return equippedBone;
    }

    public GameObject GibGameobject()
    {
        return this.gameObject;
    }
}
