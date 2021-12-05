using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leva_script : MonoBehaviour
{


    [Header("components")]
    [SerializeField] Animator animator;
    [SerializeField] GameObject player;
    [SerializeField] GameObject spowner1, spowner2, spowner3, spowner4;

    [Header("Enemies")]
    [SerializeField] GameObject enemy1;

    [Header("Others")]
    [SerializeField] int difficoltà;

    int enemyMultiplier;
    int ondata = 1;
    int numberOfEnemyForWave, nemiciRimasti;
    bool ondataIncorso = false;

    private GameObject spowner;

    private void Start()
    {
        //serve per definire quanti nemici vengono genrati a differenza della diffioltà
        switch (difficoltà)
        {
            case 1:
                enemyMultiplier = 1;
                break;
        }

        
    }
    void Update()
    {
        float differenzaX = player.transform.position.x - gameObject.transform.position.x;
        float differenzaY = player.transform.position.y - gameObject.transform.position.y;
        //Debug.Log(differenzaX);
        //Debug.Log(differenzaY);
        if (Mathf.Abs(differenzaX) < 1 && Mathf.Abs(differenzaY) < 1 && Input.GetKeyDown(KeyCode.F) && !ondataIncorso)
        {
            animator.SetBool("levaUsata", true);
            spawnEmenies();
        }
        else if (Mathf.Abs(differenzaX) < 1 && Mathf.Abs(differenzaY) < 1 && Input.GetKeyDown(KeyCode.F) && ondataIncorso)
            Debug.Log("ondata in corso");
        else
            animator.SetBool("levaUsata", false);

        if(nemiciRimasti <= 0)
        {
            ondataIncorso = false;
        }
    }

    void spawnEmenies()
    {
        numberOfEnemyForWave = 4 * enemyMultiplier + ondata;
        nemiciRimasti = numberOfEnemyForWave;
        ondataIncorso = true;
        //inizio un ciclo dove creo tot nemici
        for (int i = 0; i < numberOfEnemyForWave; i++)
        {
            //creo un nemico nella posizione di uno spowner casuale
            Instantiate(enemy1, new Vector3(spownerChoser().transform.position.x, spownerChoser().transform.position.y), gameObject.transform.rotation);
            Debug.Log("ho spownato");
        }
        ondata += 1;
    }


    public void enemyKilled()
    {
        nemiciRimasti -= 1;
        Debug.Log("nemico-1");
    }

    GameObject spownerChoser()
    {   
        switch(Random.Range(1, 4))
        {
            case 1:
                spowner = spowner1;
                break;
            case 2:
                spowner = spowner2;
                break;
            case 3:
                spowner = spowner3;
                break;
            case 4:
                spowner = spowner4;
                break;
        }
        return spowner;
    }
}
