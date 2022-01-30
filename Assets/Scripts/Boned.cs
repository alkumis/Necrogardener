using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boned : IPlanterState
{
    public IPlanterState PlantOrGrow(PlayerController player, Planter planter)
    {
        return new Boned();
    }
}
