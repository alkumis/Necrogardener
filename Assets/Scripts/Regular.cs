using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regular : IPlayerState
{
    public IPlayerState PickOrDrop(PlayerController player)
    {
        player.EquipItem(player.Equippable.GibEquipSprite);
        player.Equippable.GibGameobject.SetActive(false);
        if (player.Equippable is Bone)
        {
            Bone bone = (Bone)player.Equippable;
            player.BoneSprites = bone.GibBoneSprites;
        }
        return new Holding();
    }
}
