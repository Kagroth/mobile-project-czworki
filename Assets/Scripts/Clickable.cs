using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickable : MonoBehaviour {

    public Manager manager;
    //public BoardModel board;
    public int columnNumber;

    public void SetDiscHandler()
    {
        Debug.Log("Jestem w Clickable - SetDiscHandler!");
        Debug.Log(manager.isPaused());
        if (manager.isPaused())
            return;

        Debug.Log(string.Format("Kliknieto nr: {0}", columnNumber));
        Debug.Log(string.Format("Wrzucam dysk do kolumny nr: {0}", columnNumber));
        manager.SetDisc(columnNumber);
    }

    public void SetColumnNumber(int colNum)
    {
        columnNumber = colNum;
    }
}
