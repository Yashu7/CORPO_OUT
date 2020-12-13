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

    private List<GameRoom> createdRooms = new List<GameRoom>();

   
    public override void OnRoomListUpdate(List<RoomInfo> rooms)
    {
        
        foreach (RoomInfo room in rooms)
        {
            if(room.RemovedFromList)
            {
                int index = createdRooms.FindIndex(x => x.Room.Name == room.Name);
                if(index != 1)
                {
                    Destroy(createdRooms[index].gameObject);
                    createdRooms.RemoveAt(index);
                }
            }
            else
            {
                GameRoom gameRoom = new GameRoom();
                gameRoom = Instantiate(roomInstanceUI,roomListUI);
                gameRoom.SetRoomInfo(room);
                createdRooms.Add(gameRoom);
                
            }
            
        }
    }
    public void RefreshList()
    {
       
    }
}
