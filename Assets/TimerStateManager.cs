using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStateManager : MonoBehaviour
{
    TimerStateTura tura= new TimerStateTura();
    TimerStateOffTura OffTura= new TimerStateOffTura();
    TimerStateSum sum = new TimerStateSum();
    TimerNullState nullstate = new TimerNullState();
    TimerState currState;
    public float TimeLimitTour,MinTimeTour;
    public float TimeLimitOffTour,MinTimeOff;
    public delegate void OnTourEnd();
    public static event OnTourEnd PoSkonczeniuTury;
    public delegate void OnOffTourEnd();
    public static event OnOffTourEnd PoSkonczeniuOffTury;
    public delegate void OnSumEnd();
    public static event OnSumEnd SumUpTura;

    void Start()
    {
        currState = tura;
        currState.OnStart(this);
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        currState.OnUpdate(this);
    }
    public void ChangeToOff()
    {
        PoSkonczeniuTury?.Invoke();
        currState = OffTura;
        currState.OnStart(this);
    }
    public void ChangeToTour()
    {
        PoSkonczeniuOffTury?.Invoke();
        currState = tura;
        currState.OnStart(this);
    }
    public void ChangeToSum()
    {
        SumUpTura?.Invoke();
        currState = sum;
        currState.OnStart(this);
    }

}
