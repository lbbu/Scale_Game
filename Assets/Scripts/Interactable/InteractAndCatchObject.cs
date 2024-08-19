using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAndCatchObject : InteractableObject
{


    public override void InteractAction()
    {

        PlayerInteract.Instance.ableToInteract = false;

        transform.parent.parent = Player.Instance.catchedObjectPos;
        transform.parent.localPosition = Vector3.zero;
        transform.parent.rotation = transform.parent.parent.rotation;

    }

    public override void AltInteractAction()
    {

        PlayerInteract.Instance.ableToInteract = true;

        transform.parent.SetParent(null);
        transform.parent.GetComponent<Rigidbody>().isKinematic = false;

        Invoke(nameof(MakeObjectKinematic), 2f);
    }

    private void MakeObjectKinematic()
    {
        transform.parent.GetComponent<Rigidbody>().isKinematic = true;
    }

    public override void ScaleUp()
    {

        if (transform.localScale.x >= 3)
        {
            Player.Instance.scaleFactor = 0;
        }
        else
        {
            Player.Instance.scaleFactor = 1;
        }

        transform.localScale += new Vector3(Player.Instance.scaleFactor, Player.Instance.scaleFactor,
            Player.Instance.scaleFactor) * Time.deltaTime;

        trancparentCube.transform.localScale
            += new Vector3(Player.Instance.scaleFactor, Player.Instance.scaleFactor, Player.Instance.scaleFactor) * Time.deltaTime;

        Player.Instance.catchedObjectPos.Translate(0, 0, Player.Instance.scaleFactor * Time.deltaTime);

        transform.parent.localPosition = Vector3.zero;

    }


    public override void ScaleDawn()
    {

        if (transform.localScale.x <= 0.2f)
        {
            Player.Instance.scaleFactor = 0;
        }
        else
        {
            Player.Instance.scaleFactor = 1;
        }


        transform.localScale += new Vector3(-Player.Instance.scaleFactor, -Player.Instance.scaleFactor,
            -Player.Instance.scaleFactor) * Time.deltaTime;

        trancparentCube.transform.localScale
            += new Vector3(-Player.Instance.scaleFactor, -Player.Instance.scaleFactor, -Player.Instance.scaleFactor) * Time.deltaTime;

        Player.Instance.catchedObjectPos.Translate(0, 0, -Player.Instance.scaleFactor * Time.deltaTime);

        transform.parent.localPosition = Vector3.zero;

    }

}
