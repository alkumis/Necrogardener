using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotBoned : IPlanterState
{
    public IPlanterState PlantOrGrow(PlayerController player, Planter planter)
    {
        planter.EquipBone(player.PlanterBone);
        player.UnequipItem();
        planter.DisableInteraction(player);

        return new Boned();
    }
}
