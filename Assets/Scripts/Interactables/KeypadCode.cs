using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadCode : Interactable
{
    public int[] code = new int[4] {1,2,3,4};
    public int[] playerCode = new int[4];
    [SerializeField] private GameObject door;
    private short iterator = 0;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (iterator > 3)
        {
            if (playerCode[0] == code[0] && playerCode[1] == code[1] && playerCode[2] == code[2] && playerCode[3] == code[3])
            {
                Debug.Log("Poprawny kod");
                doorOpen = true;
                door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
            }
            else
            {
                Debug.Log("Niepoprawny kod");
                playerCode[0] = 0;
                playerCode[1] = 0;
                playerCode[2] = 0;
                playerCode[3] = 0;
                doorOpen = false;
                door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
            }
            iterator = 0;
        }
    }

    public void AddToCode(int number)
    {
        playerCode[iterator] = number;
        iterator++;
        
    }
}
