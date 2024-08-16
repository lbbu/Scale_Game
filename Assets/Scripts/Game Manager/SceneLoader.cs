using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BUTTON_PLAY()
    {

        SceneManager.LoadSceneAsync("Game");

    }

    public void BUTTON_QUIT()
    {
        Application.Quit();
    }

    public void BUTTON_MAIN_MENU()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }


    public void BUTTON_OPTION_MENU()
    {
        SceneManager.LoadSceneAsync("OptionMenu");
    }

}
