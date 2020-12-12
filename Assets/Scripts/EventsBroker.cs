using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Photon.Realtime;
using Photon.Pun;

public class EventsBroker
{
    
    #region Delegates Declaration
     public delegate void PassObject<T>(T obj);

    public static event PassObject<RoomInfo> OnJoinRoom;
    public static event Action OnNameEntered;

    #endregion

    #region Delegates Calls

    public static void CallNameEntered()
    {
        if(OnNameEntered != null)
        {
            OnNameEntered();
        }
    }
    public static void CallJoinRoom(RoomInfo room)
    {
        if(OnJoinRoom != null)
        {
            OnJoinRoom(room);
        }
    }


    #endregion

}
   
