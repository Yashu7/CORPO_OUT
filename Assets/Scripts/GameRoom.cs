using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class GameRoom : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text text;

    public RoomInfo Room {get;private set; }
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        Room = roomInfo;
        text.text = roomInfo.Name;
    }

    public void PassGameRoomInfo()
    {
        EventsBroker.CallJoinRoom(Room);
    }
    
}
