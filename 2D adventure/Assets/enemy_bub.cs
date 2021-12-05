using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bub : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] GameObject player;
    [SerializeField] GameObject levaOndate;


    [Header("Enemy stats")]
    [SerializeField] float speed;
    [SerializeField] int healt;
    public int damage;

    leva_script metodo_enemyKilled;
    private void Start()
    {
        
        metodo_enemyKilled = levaOndate.GetComponent<leva_script>();
    }
    void Update()
    {
        if (player.transform.position.x < transform.position.x)
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        else
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        //if ()
        if (healt <= 0)
        {
            BroadcastMessage("EnemyKilled");
            Destroy(gameObject);
        }
    }


    void EnemyKilled()
    {
        metodo_enemyKilled.enemyKilled();
    }
}
