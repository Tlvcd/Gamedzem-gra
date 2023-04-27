using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStateSum : TimerState
{


    public override void OnStart(TimerStateManager par)
    {
        par.Invoke("ChangeToTour", 5);
    }
    public override void OnUpdate(TimerStateManager par)
    {
        
    }
}
