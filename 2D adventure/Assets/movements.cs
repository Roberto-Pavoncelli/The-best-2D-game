using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    
    

    [Header("components")]
    [SerializeField] Animator animator;
    [SerializeField] GameObject Player;
    player leggiVelocit�;
    private void Start()
    {
        leggiVelocit� = gameObject.GetComponent<player>();   
    }



    void FixedUpdate()
    {
        float velocit� = leggiVelocit�.velocit�;
        float horizontalMove = Input.GetAxisRaw("Horizontal") * velocit�;
        float verticalMove = Input.GetAxisRaw("Vertical") * velocit�;
        animator.SetFloat("Velocit�", Mathf.Abs(verticalMove) + Mathf.Abs(horizontalMove));

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1) * Time.fixedDeltaTime * velocit�;
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0) * Time.fixedDeltaTime * velocit�;
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0) * Time.fixedDeltaTime * velocit�;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1) * Time.fixedDeltaTime * velocit�;
        }
    }

}
