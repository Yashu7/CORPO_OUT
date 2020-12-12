using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

[RequireComponent(typeof(InputField))]
public class EnterPlayerName : MonoBehaviour
{
    
    #region CONSTANT Fields
    //Key for fiding players name in Unity's PlayerPrefs
    const string playerNameKey = "PlayerName";

    #endregion

    #region Monobehaviour Methods

    void Start()
    {
        string defaultName = string.Empty;
        InputField input = this.GetComponent<InputField>();
        if(input != null)
        {
            if(PlayerPrefs.HasKey(playerNameKey))
            {
                defaultName = PlayerPrefs.GetString(playerNameKey);
                input.text = defaultName;
            }
        }

        PhotonNetwork.NickName = defaultName;
    }

    #endregion

    #region Public Methods

    public void SetPlayerGlobalName(string playerName)
    {
        playerName = GetComponentInChildren<InputField>().text;
        if(string.IsNullOrEmpty(playerName))
        {
            Debug.LogError("Player's name is empty");
            return;
        }
        PhotonNetwork.NickName = playerName;
        PlayerPrefs.SetString(playerNameKey, playerName);
        EventsBroker.CallNameEntered();
    }

    #endregion
}
