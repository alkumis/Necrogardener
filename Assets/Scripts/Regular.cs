using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regular : IPlayerState
{
    public IPlayerState PickOrDrop(PlayerController player)
    {
        player.EquipItem(player.Equippable.GibEquipSprite());
        player.PlanterBone = player.Equippable.GibPlanterSprite();
        player.Equippable.GibGameobject().SetActive(false);
        return new Holding();
    }
}
