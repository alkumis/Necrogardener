using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boned : IPlanterState
{
    private int _planterBoneStage = 0;

    public IPlanterState PlantOrGrow(PlayerController player, Planter planter)
    {
        Sprite[] boneStages = planter.PlantedBoneSprites.PlanterBoneStages;
        planter.EquipBone(boneStages[_planterBoneStage]);
        _planterBoneStage++;

        if (_planterBoneStage == boneStages.Length)
        {
            player.UnequipItem();
            planter.DisableInteraction(player);
            return new NotBoned();
        }

        return this;
    }
}
