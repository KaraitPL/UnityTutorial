using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    [SerializeField] private int buttonNumber;
    private KeypadCode keypadCode;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        keypadCode = GameObject.Find("KeypadCode").GetComponent<KeypadCode>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isPressed", false);
    }

    protected override void Interact()
    {
        animator.SetBool("isPressed", true);
        keypadCode.AddToCode(buttonNumber);
    }


    
}
