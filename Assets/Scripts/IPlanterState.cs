using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanterState
{
    IPlanterState PlantOrGrow(PlayerController player, Planter planter);
}
