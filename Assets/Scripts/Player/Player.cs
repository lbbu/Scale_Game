using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player Instance;

    public Transform catchedObjectPos;

    [HideInInspector] public GameObject selectedObject;

    [HideInInspector] public GameObject catchedObject;

    [HideInInspector] public float scaleFactor = 1f;

    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject InstructionScreen;
    [SerializeField] private GameObject optionScreen;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        

    }


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        EscapePressed();


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (selectedObject)
            {
                if(PlayerInteract.Instance.ableToInteract)
                {
                    selectedObject.GetComponent<InteractableObject>().InteractAction();
                }
                else
                {
                    catchedObject.GetComponent<InteractableObject>().AltInteractAction();
                }
            }
        }
        


        if (Input.GetKey(KeyCode.E))
        {
            if(catchedObject)
            {

                catchedObject.GetComponent<InteractableObject>().ScaleUp();
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if (catchedObject)
            {

                catchedObject.GetComponent<InteractableObject>().ScaleDawn();

            }
        }


    }

   


    private void EscapePressed()
    {

        if (!Input.GetKeyDown(KeyCode.Escape))
            return;

        if (pauseScreen.activeSelf)
        {
            pauseScreen.GetComponent<PauseScreen>().Hide();
        }
        else
        {
            pauseScreen.SetActive(true);
            GameValues.Instance.ableToDoAnyThing = false;

            PlayerCam.Instance.DisAbleCamerToMove();

        }

    }


}
