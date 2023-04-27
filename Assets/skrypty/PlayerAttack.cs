using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public int isSpellOneCasted;
    public float spellOneForce;
    public GameObject Enemy;
    [SerializeField] PlayerStateManager currplayer;
    // Start is called before the first frame update
    void Start()
    {
        if (currplayer.NumerGracza == Gracz.Gracz1)
        {
        PlayerStateManager.inputy.gracz1.atak.performed += Spell1;

        }
        else
        {
            PlayerStateManager.inputy.gracz2.atak.performed += Spell1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spell1(InputAction.CallbackContext ctx)
    {
        isSpellOneCasted = 1;
        float distanceBetweenPlayers = Vector3.Distance(transform.position, Enemy.transform.position);
        if (Vector3.Distance(transform.position, Enemy.transform.position) >= 2f||Time.timeScale==0) return;
        else{
        Debug.Log(distanceBetweenPlayers);
            
            StartCoroutine(Punch(Enemy.GetComponent<CharacterController>(), new Vector3(Enemy.transform.position.x - transform.position.x, 0f, Enemy.transform.position.z - transform.position.z)));
        }
    }
    IEnumerator Punch(CharacterController chara, Vector3 dir)
    {
        float timer = 0; 
        while (timer<0.1f)
        {
         timer+= Time.deltaTime;
            chara.Move(dir*10*Time.deltaTime);
            yield return null;
        }

    }

}
