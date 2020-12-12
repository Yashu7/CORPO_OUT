using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventsBroker
{
    
    #region Delegates Declaration

    public static event Action OnNameEntered;

    public static event Action OnFindGameEntered;

    public static event Action OnWaitingLobbyEntered;

    #endregion

    #region Delegates Calls

    public static void CallNameEntered()
    {
        if(OnNameEntered != null)
        {
            OnNameEntered();
        }
    }

     public static void CallFindGameEntered()
    {
        if(OnFindGameEntered != null)
        {
            OnFindGameEntered();
        }
    }

     public static void CallWaitingLobbyEntered()
    {
        if(OnWaitingLobbyEntered != null)
        {
            OnWaitingLobbyEntered();
        }
    }

    #endregion
    
}
   
