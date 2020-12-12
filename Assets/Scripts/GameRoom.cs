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

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        text.text = roomInfo.Name;
    }
}
