
using UnityEngine;

public abstract class TimerState
{
    public abstract void OnStart(TimerStateManager par);
    public abstract void OnUpdate(TimerStateManager par);
}
