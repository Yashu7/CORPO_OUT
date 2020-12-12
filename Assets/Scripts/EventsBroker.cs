using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventsBroker
{
    
    #region Delegates Declaration

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


    #endregion

}
   
