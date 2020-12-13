using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class JoinGameRoom : MonoBehaviourPunCallbacks
{
    void Start()
    {
        EventsBroker.OnJoinRoom += JoinRoom;
        
    }
    public void JoinRoom(RoomInfo room)
    {
        PhotonNetwork.JoinRoom(room.Name);
    }
}
