using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Buttoms;
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToShop()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void ExitFromGame()
    {
        Application.Quit();
    }

    public void LaunchSettingsPanel()
    {
        Panel.SetActive(true);
        Buttoms.SetActive(false);
    }
    public void QuitSettingsPanel()
    { 
        Panel.SetActive(false);
        Buttoms.SetActive(true);
    }
}
