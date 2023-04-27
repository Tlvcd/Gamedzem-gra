using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStateTura : TimerState
{
    float timer;

    public override void OnStart(TimerStateManager par)
    {
        timer = 0f;
    }
    public override void OnUpdate(TimerStateManager par)
    {
            timer += Time.deltaTime;
        if (timer >= par.TimeLimitTour)
        { 
            if (par.TimeLimitTour > par.MinTimeTour) //<- 3 sekundy to minimum czasu
            {
                par.TimeLimitTour-=0.5f; //<-zmniejszenie limitu
                par.ChangeToOff();
            }
            timer = 0; //<- zerowanie czasu
        }
    }
}
