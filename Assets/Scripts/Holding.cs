using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding : IPlayerState
{
    public IPlayerState PickOrDrop(PlayerController player)
    {
        return new Regular();
    }
}
