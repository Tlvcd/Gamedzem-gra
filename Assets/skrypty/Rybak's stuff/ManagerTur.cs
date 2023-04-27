using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTur : MonoBehaviour
{
    public float Timer = 0;
    private int Turn = 1; //<- która tura teraz leci, może się przydać kiedyś czy coś
    [SerializeField] float MinTime;
    [HideInInspector]
    public float Limit = 10; //limit sekund
    public static bool czyTuraSkonczona;
    //<- dzięki temu kontrolujesz, kiedy ma się zacząć kolejne losowanie
    // Start is called before the first frame update
    public delegate void OnTourEnd();
    public static event OnTourEnd PoSkonczeniuTury;
    void Start()
    {
        czyTuraSkonczona = false;
    }

    public void NewTimer(float time)
    {

    }

    void Update()
    {
        if (!czyTuraSkonczona)
        {
            Timer += Time.deltaTime;
        }
        if (Timer >= Limit)
        {
            czyTuraSkonczona = true;
            PoSkonczeniuTury?.Invoke();
            Debug.Log("Time's up after: " + Limit); //<- wpierdol tu to, co się będzie dzialo po upływie czasu, zamiast tej linijki
            Turn++;
            if (Limit > MinTime) //<- 3 sekundy to minimum czasu
            {
                Limit--; //<-zmniejszenie limitu
            }
            czyTuraSkonczona = false;
            Timer = 0; //<- zerowanie czasu
        }
    }
}