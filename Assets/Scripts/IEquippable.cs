using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquippable : IInteractable
{
    Sprite GibEquipSprite();

    GameObject GibGameobject();
}
