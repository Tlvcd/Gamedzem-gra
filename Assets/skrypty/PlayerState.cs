using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    public abstract void OnStart(PlayerStateManager dane);

    public abstract void OnUpdate(PlayerStateManager dane);
}
