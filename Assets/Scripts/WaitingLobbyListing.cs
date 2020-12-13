using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class WaitingLobbyListing : MonoBehaviourPunCallbacks
{
    public Transform playersListUI;
    public GamePlayer lobbyInstanceUI;

    public List<GamePlayer> playersList = new List<GamePlayer>();
   
    public override void OnJoinedRoom()
    {
        foreach(var p in PhotonNetwork.PlayerList)
        {   
             
            GamePlayer gamePlayer = Instantiate(lobbyInstanceUI,playersListUI);
            gamePlayer.SetPlayerInfo(p);
            playersList.Add(gamePlayer);
        }
    }
  
    public override void OnPlayerLeftRoom(Player player)
    {   
            Debug.Log("PLAYER LEAVING " + player.NickName);
            int index = playersList.FindIndex(x => x.Player == player);
                Destroy(playersList[index].gameObject);
                playersList.RemoveAt(index);
            
    }

    public override void OnPlayerEnteredRoom(Player player)
    {
        
        GamePlayer gamePlayer = new GamePlayer();
        gamePlayer = Instantiate(lobbyInstanceUI,playersListUI);
        gamePlayer.SetPlayerInfo(player);
        playersList.Add(gamePlayer);
            
    }

}
