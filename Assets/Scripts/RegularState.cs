using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularState : IPlayerState
{
    public void PickOrDrop(PlayerController player)
    {
        player.EquipItem(player.interactable.GibSprite());
        player.interactable.GibGameobject().SetActive(false);
    }
}
