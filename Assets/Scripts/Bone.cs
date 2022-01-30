using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : Item
{
    [SerializeField]
    private Sprite _planterItem;

    public Sprite GibPlanterSprite()
    {
        return _planterItem;
    }
}
