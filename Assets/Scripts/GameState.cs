using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static int CollectedСoins { get; private set; }
    public static int DistanceTraveled { get; private set; }

    public static void AddCoin(int numberCoin)
    {
        CollectedСoins += numberCoin;
    }

    public static void AddDistance()
    {
        DistanceTraveled += 1;
    }
}
