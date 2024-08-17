using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player Instance;

    public TextMeshProUGUI messageText;

    [SerializeField] private GameObject darkMoodImage;
    [SerializeField] private GameObject lightMoodImage;

    [SerializeField] private GameObject[] darkMoodObjects;
    [SerializeField] private GameObject[] lightMoodObjects;

    [SerializeField] private GameObject[] bookScreens;
    [SerializeField] private GameObject calcScreen;
    [SerializeField] private GameObject exitScreen;


    private bool darkMood;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        darkMoodImage.SetActive(false);
        lightMoodImage.SetActive(true);
        darkMood = false;

        ActivatAndHideObjects(lightMoodObjects, darkMoodObjects);

    }


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        EscapePressed();


        if (Input.GetKeyDown(KeyCode.Q)) 
        {

            if(darkMood)
            {

                darkMoodImage.SetActive(false);
                lightMoodImage.SetActive(true);

                darkMood = false;

                ActivatAndHideObjects(lightMoodObjects, darkMoodObjects);

            }
            else
            {
                darkMoodImage.SetActive(true);
                lightMoodImage.SetActive(false);

                darkMood = true;

                ActivatAndHideObjects(darkMoodObjects, lightMoodObjects);

            }

        }

    }

    private void ActivatAndHideObjects(GameObject[] activateObjects, GameObject[] hideObjects)
    {

        foreach(GameObject obj in activateObjects)
        {
            obj.SetActive(true);
        }

        foreach(GameObject obj in hideObjects)
        {
            obj.SetActive(false);
        }

    }


    private void EscapePressed()
    {
        
        foreach(var bookScreen in bookScreens)
        {
            if (bookScreen.activeSelf)
            {

                bookScreen.SetActive(false);

                PlayerCam.Instance.AbleCamerToMove();

                PlayerMovement.Instance.ableToMove = true;

                return;

            }
        }

        
        if (calcScreen.activeSelf)
        {

            calcScreen.SetActive(false);

            PlayerCam.Instance.AbleCamerToMove();

            PlayerMovement.Instance.ableToMove = true;

        }
        else if (exitScreen.activeSelf)
        {

            exitScreen.SetActive(false);

            PlayerCam.Instance.AbleCamerToMove();

            PlayerMovement.Instance.ableToMove = true;

        }
        else
        {
            exitScreen.SetActive(true);

            PlayerCam.Instance.DisAbleCamerToMove();

            PlayerMovement.Instance.ableToMove = false;
        }

    }


}
