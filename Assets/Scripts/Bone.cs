using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : Item
{
    [SerializeField]
    private BoneSprites _boneSprites;

    public BoneSprites GibBoneSprites { get { return _boneSprites; } }
}
