using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    [Header("Components")]
    [SerializeField] GameObject enemyBub;


    [Header("Caratteristiche")]
    [SerializeField] int healt;
    public int velocità;

    enemy_bub getDamageint;

    private void Start()
    {
        getDamageint = enemyBub.GetComponent<enemy_bub>();
        
    }
    private void FixedUpdate()
    {
        if (healt <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int enemyDamage = getDamageint.damage;
        if ((collision.gameObject.tag).Equals("enemy"))
        {
            healt -= enemyDamage;
            Debug.Log("ho colpito un nemico");
            Destroy(collision.gameObject);
        }
    }
}
