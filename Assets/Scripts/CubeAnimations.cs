using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimations : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();   
    }
    public void action()
    {
        animator.SetTrigger("Drop");


    }
}
