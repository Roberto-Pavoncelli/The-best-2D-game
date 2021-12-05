using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leva_script : MonoBehaviour
{


    [Header("components")]
    [SerializeField] Animator animator;
    [SerializeField] GameObject player;


    void Update()
    {

        float differenzaX = player.transform.position.x - gameObject.transform.position.x;
        float differenzaY = player.transform.position.y - gameObject.transform.position.y;
        Debug.Log(differenzaX);
        Debug.Log(differenzaY);
        if (Mathf.Abs(differenzaX) < 1 && Mathf.Abs(differenzaY) < 1 && Input.GetKeyDown(KeyCode.F))
            animator.SetBool("levaUsata", true);
        else
            animator.SetBool("levaUsata", false);
    }
}
