using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    [SerializeField] private GameObject textbox;
    bool isopen;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isopen = true;
        }
        else { isopen = false; }
        if (isopen == true)
        {
            animator.SetBool("Text Typing", true);
        }
        else { animator.SetBool("Text Typing", false); }


    }
}
