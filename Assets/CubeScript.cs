using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Color CubeColor;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            other.GetComponent<PlayerStateManager>().ObecnyKolorPola = CubeColor;
        }
    }
}
