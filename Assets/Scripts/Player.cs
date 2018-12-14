using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    public PlayerColor playerColor;

    public PlayerColor GetPlayerColor()
    {
        return playerColor;
    }

    public void SetPlayerColor(PlayerColor color)
    {
        playerColor = color;
    }
}
