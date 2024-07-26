using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private CanvasGroup cGroup;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    public GameObject settingsPanel;
    public GameObject exitPanel;
    public GameObject pausePanel;
    public GameObject infoPanel;


    void Start()
    {
        
        EndGameManager.endManager.RegisterPanelController(this);
    }

    // Update is called once per frame
    public void ActivateWin(){
        cGroup.alpha = 1;
        winScreen.SetActive(true);
        cGroup.blocksRaycasts = true;

    }

    public void ActivateLose(){
        cGroup.alpha = 1;
        loseScreen.SetActive(true);
        cGroup.blocksRaycasts = true;
    }

    public void ShowSettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void HideSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }

    public void ShowExitPanel()
    {
        exitPanel.SetActive(true);
    }

    public void HideExitPanel()
    {
        exitPanel.SetActive(false);
    }

    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfoPanel()
    {
        infoPanel.SetActive(false);
    }

    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
    }

    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
