using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{

    [Header("caratteristiche player")]
    [SerializeField] float velocit�;

    [Header("components")]
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal") * velocit�;
        float verticalMove = Input.GetAxisRaw("Vertical") * velocit�;
        animator.SetFloat("Velocit�", Mathf.Abs(verticalMove) + Mathf.Abs(horizontalMove));

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1) * Time.deltaTime * velocit�;
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0) * Time.deltaTime * velocit�;
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0) * Time.deltaTime * velocit�;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1) * Time.deltaTime * velocit�;
        }
    }
}
