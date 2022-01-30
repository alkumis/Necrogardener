using UnityEngine;

public interface IInteractable
{
    void EnableInteraction(PlayerController player);

    void DisableInteraction(PlayerController player);

    Sprite GibEquipSprite();

    Sprite GibPlanterSprite();

    GameObject GibGameobject();
}
