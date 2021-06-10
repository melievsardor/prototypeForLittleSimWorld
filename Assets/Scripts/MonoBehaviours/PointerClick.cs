using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerClick : MonoBehaviour
{
    [SerializeField]
    private Interactable interactable = null;

    private SimpleCharacterController controller;


    private void Start()
    {
        controller = FindObjectOfType<SimpleCharacterController>();
    }



    private void OnMouseDown()
    {
        if(interactable != null)
        {
            controller.OnInteractableClick(interactable);
        }
    }



}
