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

    private List<GamePlayer> playersList = new List<GamePlayer>();
    void Start()
    {
        EventsBroker.OnRoomCreated += AddOwner;
        
    }
    public void AddOwner()
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
            int index = playersList.FindIndex(x => x.Player == player);
            if(index != 1)
            {
                Destroy(playersList[index].gameObject);
                playersList.RemoveAt(index);
            }
    }

    public override void OnPlayerEnteredRoom(Player player)
    {
        
        GamePlayer gamePlayer = new GamePlayer();
        gamePlayer = Instantiate(lobbyInstanceUI,playersListUI);
        gamePlayer.SetPlayerInfo(player);
        playersList.Add(gamePlayer);
            
    }

}
