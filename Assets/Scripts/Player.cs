using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private PlayerColor playerColor;

    [SerializeField]
    private bool active;

    public void SetActive(bool activate)
    {
        active = activate;
    }

    public bool IsActive()
    {
        return active;
    }

    public PlayerColor GetPlayerColor()
    {
        return playerColor;
    }

    public void SetPlayerColor(PlayerColor color)
    {
        playerColor = color;
    }
}
