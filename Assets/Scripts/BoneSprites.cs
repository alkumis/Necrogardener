using UnityEngine;

[CreateAssetMenu(fileName = "BoneSprites", menuName = "ScriptableObjects/BoneSprites", order = 1)]
public class BoneSprites : ScriptableObject
{
    public Sprite PlanterBone;
    public Sprite[] PlanterBoneStages;
}