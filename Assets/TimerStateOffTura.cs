using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStateOffTura : TimerState
{
    float timer;

    public override void OnStart(TimerStateManager par)
    {
        timer = 0f;
    }
    public override void OnUpdate(TimerStateManager par)
    {
        timer += Time.deltaTime;
        if (timer >= par.TimeLimitOffTour)
        {
            if (par.TimeLimitOffTour > par.MinTimeOff) //<- 3 sekundy to minimum czasu
            {
                par.TimeLimitOffTour -= 0.5f; //<-zmniejszenie limitu
                par.ChangeToSum();
            }
            timer = 0; //<- zerowanie czasu
        }
    }
}
