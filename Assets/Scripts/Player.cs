using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// reprezentacja gracza
public class Player : MonoBehaviour {

    [SerializeField]
    private PlayerColor playerColor;

    [SerializeField]
    private bool active;

    // ustaw ruch gracza
    public void SetActive(bool activate)
    {
        active = activate;
    }

    // czy jest ruch gracza
    public bool IsActive()
    {
        return active;
    }

    // pobierz kolor gracza
    public PlayerColor GetPlayerColor()
    {
        return playerColor;
    }

    // ustaw kolor gracza
    public void SetPlayerColor(PlayerColor color)
    {
        playerColor = color;
    }
}
