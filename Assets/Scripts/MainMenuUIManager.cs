using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuUIManager : MonoBehaviour
{

    #region Private Fields

    [Tooltip("UIs Game Objects of Main Menu")]
    [SerializeField]
    private GameObject enterNameUI, chooseGameModeUI,findGameUI,waitingLobbyUI,createGameRoomUI;

    #endregion

    #region MonoBehaviour Methods
    void Start()
    {
        EventsBroker.OnNameEntered += SetActiveChooseGameModeUI;
    }
    void OnDisable()
    {
         EventsBroker.OnNameEntered -= SetActiveChooseGameModeUI;
    }
    #endregion

    #region Public Methods

    public void SetActiveChooseGameModeUI()
    {
        DeactivateAllUIs();
        chooseGameModeUI.SetActive(true);
    }

    public void SetActiveFindGameUI()
    {
        DeactivateAllUIs();
        
        findGameUI.SetActive(true);
    }

    public void SetActiveWaitingLobbyUI()
    {
        DeactivateAllUIs();
        waitingLobbyUI.SetActive(true);
    }
    public void SetActiveCreateGameRoomUI()
    {
        DeactivateAllUIs();
        createGameRoomUI.SetActive(true);
    }
    
    private void DeactivateAllUIs()
    {
        foreach (Transform UI in transform)
        {
             UI.gameObject.SetActive(false);
        }
    }

    #endregion
    
}
