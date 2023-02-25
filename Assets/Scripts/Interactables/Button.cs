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

    }

    protected override void Interact()
    {
        animator.SetTrigger("buttonPress");
        keypadCode.AddToCode(buttonNumber);
    }


    
}
