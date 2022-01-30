using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regular : IPlayerState
{
    public IPlayerState PickOrDrop(PlayerController player)
    {
        player.EquipItem(player.Interactable.GibEquipSprite());
        player.Interactable.GibGameobject().SetActive(false);
        return new Holding();
    }
}
