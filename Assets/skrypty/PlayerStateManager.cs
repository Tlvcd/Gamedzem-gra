
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateManager : MonoBehaviour
{
    private PlayerMoveState move;
    TimerNullState nullstate=new TimerNullState();
    public PlayerState Curr_State;
    public static Gracz1 inputy;
    public float PlayerSpeed, DampSpeed;
    public Color ObecnyKolorPola;
    [SerializeField] CheckerGen generator;
    [System.NonSerialized]
    public CharacterController player;
    public Gracz NumerGracza = new Gracz();
    public Color CorrectColor;

    private void Awake()
    {

        player = GetComponent<CharacterController>();
        move = new PlayerMoveState();
        inputy = new Gracz1();
        inputy.Enable();
        Curr_State = move;
        CheckerGen.Generated += GenCorrectColor;
        TimerStateManager.PoSkonczeniuTury += ChangeColorToCorrect;

    }

    void GenCorrectColor()
    {
        

            CorrectColor = generator.KoloriKostek[Random.Range(0, generator.KoloriKostek.Count-1)];
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    void ChangeColorToCorrect()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = CorrectColor;
    }
    void Start()
    {
        Curr_State.OnStart(this);
    }

    // Update is called once per frame
    void Update()
    {
        Curr_State.OnUpdate(this);
    }
    public void ToNullState()
    {
        Curr_State = nullstate;
    }
}
    public enum Gracz
    {
        Gracz1,
        Gracz2
    }
