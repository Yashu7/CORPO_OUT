using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

[RequireComponent(typeof(InputField))]
public class EnterPlayerName : MonoBehaviour
{
    //Key for fiding players name in Unity's PlayerPrefs
    const string playerNameKey = "PlayerName";

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

    public void SetPlayerGlobalName(string playerName)
    {
        if(string.IsNullOrEmpty(playerName))
        {
            Debug.LogError("Player's name is empty");
            return;
        }
        PhotonNetwork.NickName = playerName;
        PlayerPrefs.SetString(playerNameKey, playerName);
    }
}
