using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{

    public void Hide()
    {
        PlayerCam.Instance.DisAbleCamerToMove();
        GameValues.Instance.ableToDoAnyThing = true;
        gameObject.SetActive(false);
    }

}
