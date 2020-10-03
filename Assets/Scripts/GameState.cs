using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static int CollectedСoins { get; set; }
    public static int DistanceTraveled { get; set; }

    public static void AddCoin(int numberCoin)
    {
        CollectedСoins += numberCoin;
    }

    public static void AddDistance()
    {
        DistanceTraveled += 1;
    }
}
