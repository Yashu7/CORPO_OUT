using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class GamePlayer : MonoBehaviourPunCallbacks
{
    public Text text;
    public Player Player {get;private set;}

    public void SetPlayerInfo(Player _player)
    {
        Player = _player;
        text.text = _player.NickName;
    }
}
