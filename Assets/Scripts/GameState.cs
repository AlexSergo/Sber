using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates
{
    Tourist,
    Citizen
}

public static class GameState
{
    public static GameStates State = GameStates.Tourist;
}
