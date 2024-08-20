using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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

    public virtual void AltInteractAction()
    {

    }

    public virtual void ScaleUp()
    {

    }

    public virtual void ScaleDawn()
    {

    }

}

    