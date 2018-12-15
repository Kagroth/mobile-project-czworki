using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// kontroler interfejsu
public class UIController : MonoBehaviour {

    public GameObject winInfoPopupPrefab;
    private GameObject winInfoPopup;

	// Use this for initialization
	void Start () {
	}

    // ustawienie obrazka jako informacji kto wykonuje teraz ruch
    public void ChangeNextPlayerSprite(Sprite spr)
    {
        GameObject.FindGameObjectWithTag("NextPlayerImage").GetComponent<Image>().sprite = spr;
    }

    // wyswietla komunikat o zwyciestwie/remisie
    public void ShowWinInfo(string winnerColor)
    {
        winInfoPopup = Instantiate(winInfoPopupPrefab);
        winInfoPopup.transform.SetParent(GameObject.FindObjectOfType<Canvas>().transform);

        // wyśrodkowanie okienka
        winInfoPopup.GetComponent<RectTransform>().position = Vector3.zero;
        winInfoPopup.GetComponent<RectTransform>().localPosition = Vector3.zero;

        string message;

        if(winnerColor.Equals("Draw"))
        {
            message = "Draw!";
        }
        else
        {
            message = string.Format("Player {0} win!", winnerColor);
        }

        winInfoPopup.GetComponentInChildren<Text>().text = message;
    }

    // obsługa ponownego uruchomienia rozgrywki
    public void PlayAgainHandler()
    {
        Debug.Log("Gramy jeszcze raz!");
        gameObject.GetComponent<Manager>().SetPause(false);
        PlayGameHandler();
    }

    // obsługa zakonczenia rozgrywki
    public void EndHandler()
    {
        Debug.Log("Wracamy do menu glownego!");
        gameObject.GetComponent<Manager>().SetPause(false);
        SceneManager.LoadScene("menu");
    }

    // obsluga przelaczania menu w Menu głównym
    public void SwitchMenuHandler()
    {
        GetComponent<MenuManager>().SwitchMenu();
    }

    // obsługa rozpoczęcia rozgrywki w tyrbie gracz vs gracz
    public void PlayOneVsOneHandler()
    {
        GetComponent<MenuManager>().SetGameMode(GameMode.OneVsOne);
        PlayGameHandler();
    }

    // obsługa rozpoczęcia rozgrywki w trybie gracz vs komputer
    public void PlayOneVsComputerHandler()
    {
        GetComponent<MenuManager>().SetGameMode(GameMode.OneVsComputer);
        PlayGameHandler();
    }

    // obsługa rozpoczęcia rozgrywki - załadowanie sceny
    public void PlayGameHandler()
    {
        SceneManager.LoadScene("main");
    }

    // obsługa wyjscia z aplikacji
    public void QuitGameHandler()
    {
        Debug.Break();
        Application.Quit();
    }
}
