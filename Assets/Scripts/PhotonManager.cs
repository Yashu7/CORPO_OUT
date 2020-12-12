using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    string gameVersion = "0.0.1";
    
    [Tooltip("Name of created room")]
    [SerializeField]
    private string roomName;

    void Awake()
    {
        //Makes sure all players are in the same room.
        PhotonNetwork.AutomaticallySyncScene = true;
    }
    
    void Start()
    {
        Connect();
    }

    public void Connect()
    {
            PhotonNetwork.GameVersion = gameVersion;
            PhotonNetwork.ConnectUsingSettings();
            
           
        
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("PUN Basics Tutorial/Launcher: OnConnectedToMaster() was called by PUN");
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
    }

    

}
