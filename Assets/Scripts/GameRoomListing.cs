using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class GameRoomListing : MonoBehaviourPunCallbacks
{
    public Transform roomListUI;
    public GameRoom roomInstanceUI;

    public override void OnRoomListUpdate(List<RoomInfo> rooms)
    {
        Debug.Log("Game List Updated");
        foreach (RoomInfo room in rooms)
        {
            GameRoom gameRoom = Instantiate(roomInstanceUI,roomListUI);
            gameRoom.SetRoomInfo(room);
        }
    }
}
