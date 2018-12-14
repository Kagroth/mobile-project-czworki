using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public GameObject winInfoPopupPrefab;
    private GameObject winInfoPopup;

	// Use this for initialization
	void Start () {
	}

    public void ChangeNextPlayerSprite(Sprite spr)
    {
        GameObject.FindGameObjectWithTag("NextPlayerImage").GetComponent<Image>().sprite = spr;
    }

    public void ShowWinInfo(string winnerColor)
    {
        winInfoPopup = Instantiate(winInfoPopupPrefab);
        winInfoPopup.transform.SetParent(GameObject.FindObjectOfType<Canvas>().transform);

        // wyśrodkowanie okienka
        winInfoPopup.GetComponent<RectTransform>().position = Vector3.zero;
        winInfoPopup.GetComponent<RectTransform>().localPosition = Vector3.zero;

        string message;

        if(winnerColor.Equals("Remis"))
        {
            message = "Remis!";
        }
        else
        {
            message = string.Format("Gracz {0} wygrał!", winnerColor);
        }

        winInfoPopup.GetComponentInChildren<Text>().text = message;
    }

    public void PlayAgainHandler()
    {
        Debug.Log("Gramy jeszcze raz!");
        gameObject.GetComponent<Manager>().SetPause(false);
        PlayGameHandler();
    }

    public void EndHandler()
    {
        Debug.Log("Wracamy do menu glownego!");
        gameObject.GetComponent<Manager>().SetPause(false);
        SceneManager.LoadScene("menu");
    }

    public void PlayGameHandler()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitGameHandler()
    {
        Debug.Break();
        Application.Quit();
    }
}
