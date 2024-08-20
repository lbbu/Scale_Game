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
        if (Input.GetKeyDown(KeyCode.E)) {
        transform.localScale = new Vector3((float)0.5+transform.localScale.x, (float)0.5 + transform.localScale.y, (float)0.5 + transform.localScale.z);
            trancparentCube.transform.localScale = new Vector3((float)0.5 + trancparentCube.transform.localScale.x, (float)0.5 + trancparentCube.transform.localScale.y, (float)0.5 + trancparentCube.transform.localScale.z);

    public virtual void AltInteractAction()
    {

        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
           
            
                transform.localScale = new Vector3((float)(transform.localScale.x - 0.5), (float)(transform.localScale.y - 0.5), (float)(transform.localScale.z - 0.5));
                trancparentCube.transform.localScale = new Vector3((float)(trancparentCube.transform.localScale.x - 0.5), (float)(trancparentCube.transform.localScale.y - 0.5), (float)(trancparentCube.transform.localScale.z - 0.5));
            
                

        }

    }

}
