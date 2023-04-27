using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoveState : PlayerState
{
    private Vector2 move,reference,mov;

    public override void OnStart(PlayerStateManager dane)
    {
        Debug.Log("started");
    }

    public override void OnUpdate(PlayerStateManager dane)
    {
        if (dane.NumerGracza == Gracz.Gracz1) { mov = PlayerStateManager.inputy.gracz1.poruszanie.ReadValue<Vector2>(); }
        else { mov = PlayerStateManager.inputy.gracz2.poruszanie.ReadValue<Vector2>(); }
        
        move = Vector2.SmoothDamp(move, mov, ref reference, dane.DampSpeed);
        if (mov.magnitude == 0) { move = Vector3.zero; }
        Vector3 calc =new Vector3(move.x, 0,move.y).normalized;
        dane.player.SimpleMove(dane.transform.TransformVector(calc * dane.PlayerSpeed));
    }
}
