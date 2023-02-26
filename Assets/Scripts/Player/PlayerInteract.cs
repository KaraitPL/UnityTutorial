using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera playerCamera;
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask mask;
    private PlayerUI playerUI;

    void Start()
    {
        playerCamera = GetComponent<PlayerController>().playerCamera;
        playerUI = GetComponent<PlayerUI>();
    }


    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);
        RaycastHit hitInfo; //variable to store our collision information.
        if(Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
