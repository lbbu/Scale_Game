using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteractableObject : InteractableObject
{

    [SerializeField] private int nextLevelNumber;

    public override void InteractAction()
    {

        PlayerPrefs.SetInt("levelProgress", nextLevelNumber);



    }

}
