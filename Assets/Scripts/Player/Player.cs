using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player Instance;

    //[HideInInspector] public GameObject selectedObject;


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

        /*
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(selectedObject)
            {
                selectedObject.GetComponent<InteractableObject>().InteractAction();
            }
        }
        */

    }

   


    private void EscapePressed()
    {
        
       

    }


}
