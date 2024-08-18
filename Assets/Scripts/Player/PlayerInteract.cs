using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    [HideInInspector] public bool ableToInteract = true;

    [SerializeField] private Transform playerCameraTransform;

    [SerializeField] private LayerMask whatIsInteractable;

    private GameObject prevInteractableObject;
    private GameObject currentInteractableObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        InteractWithObjectToChangeTheirLook();
        InteractWithObject();

    }

    private void InteractWithObjectToChangeTheirLook()
    {
        if (ableToInteract)
        {

            float interactDistance = 2f;

            var colliderArray = Physics.RaycastAll(playerCameraTransform.position,
                playerCameraTransform.forward, interactDistance, whatIsInteractable);

            if (colliderArray.Length == 0)
            {

                // no object to interact

                currentInteractableObject = null;

                if (prevInteractableObject != null)
                {
                    prevInteractableObject.GetComponent<InteractableObject>().DeActivateTrancparentCube();
                    prevInteractableObject = null;

                }

            }
            else if (colliderArray.Length >= 1)
            {

                //one object or more to interact


                colliderArray[0].collider.gameObject.GetComponent<InteractableObject>().ActivateTrancparentCube();

                currentInteractableObject = colliderArray[0].collider.gameObject;


                if (prevInteractableObject != null)
                {
                    if (prevInteractableObject == colliderArray[0].collider.gameObject)
                    {
                    }
                    else
                    {
                        prevInteractableObject.GetComponent<InteractableObject>().DeActivateTrancparentCube();
                        prevInteractableObject = colliderArray[0].collider.gameObject;

                    }
                }
                else
                {
                    prevInteractableObject = colliderArray[0].collider.gameObject;

                }
            }
            
        }
    }


    private void InteractWithObject()
    {

        if (Input.GetKeyDown(KeyCode.E) && ableToInteract)
        {

            if(currentInteractableObject != null)
            {
                //do something
                currentInteractableObject.GetComponent<InteractableObject>().InteractAction();
            }
            else
            {
                //do nothing
            }

           
        }
        if (Input.GetKeyDown(KeyCode.Q) && ableToInteract)
        {

            if (currentInteractableObject != null)
            {
                //do something
                currentInteractableObject.GetComponent<InteractableObject>().InteractAction();
            }
            else
            {
                //do nothing
            }

        }
    }


}
