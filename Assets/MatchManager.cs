using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchManager : MonoBehaviour
{
    [SerializeField]PlayerStateManager player1;
    [SerializeField] PlayerStateManager player2;
    public Text wintext;
    [SerializeField] TimerStateManager matchtime;
    bool p2death=false, p1death=false;
    // Start is called before the first frame update
    private void Awake()
    {

        TimerStateManager.SumUpTura += CheckCorrect;
    }
    void CheckCorrect()
    {

        CheckerGen.ChangeColorCorrect(player1.CorrectColor);
        CheckerGen.ChangeColorCorrect(player2.CorrectColor);
        if (player1.CorrectColor == player1.ObecnyKolorPola)
        {

        }
        else
        {
            p1death = true;
            player1.gameObject.SetActive(false);
        }
        if (player2.CorrectColor == player2.ObecnyKolorPola)
        {

        }
        else
        {
            p2death = true;
            player2.gameObject.SetActive(false);

        }
        if (p1death && p2death) { 
            wintext.gameObject.SetActive(true);
            wintext.text = "Remis";
            matchtime.enabled = false;
            StopAllPlayers();
        }
        else if (p1death && !p2death) { 
            wintext.gameObject.SetActive(true); 
            wintext.text = "gracz 1 wygral";
            matchtime.enabled = false;
            StopAllPlayers();
        }
        else if (!p1death && p2death) { 
            wintext.gameObject.SetActive(true); 
            wintext.text = "gracz 2 wygral";
            matchtime.enabled=false;
            StopAllPlayers();
        }
    }
    void StopAllPlayers()
    {
        player1.ToNullState();
        player2.ToNullState();
    }

}
