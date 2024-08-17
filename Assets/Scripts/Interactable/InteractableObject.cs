using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    public GameObject trancparentCube;

    public virtual void ActivateTrancparentCube()
    {
        trancparentCube.SetActive(true);
    }

    public virtual void DeActivateTrancparentCube()
    {
        trancparentCube.SetActive(false);
    }

    public virtual void InteractAction()
    {



    }

}
