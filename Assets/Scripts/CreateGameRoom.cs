using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateGameRoom : MonoBehaviourPunCallbacks
{
    void Start()
    {
       
    }
    public void StartGameRoom(string roomName)
    {
        roomName = GetComponentInChildren<InputField>().text;
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(roomName,roomOptions,TypedLobby.Default);
    }
    public override void OnCreatedRoom()
    {
        Debug.Log("Room Created");
      

    }
    public override void OnCreateRoomFailed(short returnCode,string message)
    {
        Debug.Log(message);
    }
}
