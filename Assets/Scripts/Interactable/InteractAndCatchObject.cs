using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAndCatchObject : InteractableObject
{

    [SerializeField] private float maxScale = 3;
    [SerializeField] private float minScale = 0.25f;
    [SerializeField] private float scaleMultiplier = 1;

    public override void InteractAction()
    {

        Player.Instance.catchedObjectPos.localPosition = new Vector3(0, 0, transform.localScale.z + 0.5f);

        PlayerInteract.Instance.ableToInteract = false;

        transform.parent.parent = Player.Instance.catchedObjectPos;
        transform.parent.localPosition = Vector3.zero;
        transform.parent.rotation = transform.parent.parent.rotation;

        transform.GetComponent<BoxCollider>().isTrigger = true;

        Player.Instance.catchedObject = Player.Instance.selectedObject;

    }

    public override void AltInteractAction()
    {

        PlayerInteract.Instance.ableToInteract = true;

        transform.parent.SetParent(null);
        transform.GetComponent<BoxCollider>().isTrigger = false;

        transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        Invoke(nameof(MakeObjectKinematic), 2f);

        Player.Instance.catchedObject = null;

    }

    private void MakeObjectKinematic()
    {
        transform.parent.GetComponent<Rigidbody>().isKinematic = true;
    }

    public override void ScaleUp()
    {

        if (transform.localScale.x >= maxScale)
            return;

        transform.localScale += new Vector3(Player.Instance.scaleFactor * scaleMultiplier, Player.Instance.scaleFactor * scaleMultiplier,
            Player.Instance.scaleFactor * scaleMultiplier) * Time.deltaTime;

        trancparentCube.transform.localScale
            += new Vector3(Player.Instance.scaleFactor * scaleMultiplier, Player.Instance.scaleFactor * scaleMultiplier, Player.Instance.scaleFactor * scaleMultiplier) * Time.deltaTime;

        Player.Instance.catchedObjectPos.Translate(0, 0, Player.Instance.scaleFactor * Time.deltaTime);

        transform.parent.localPosition = Vector3.zero;

    }


    public override void ScaleDawn()
    {

        if (transform.localScale.x <= minScale)
            return;


        transform.localScale += new Vector3(-Player.Instance.scaleFactor * scaleMultiplier, -Player.Instance.scaleFactor * scaleMultiplier,
            -Player.Instance.scaleFactor * scaleMultiplier) * Time.deltaTime;

        trancparentCube.transform.localScale
            += new Vector3(-Player.Instance.scaleFactor * scaleMultiplier, -Player.Instance.scaleFactor * scaleMultiplier, -Player.Instance.scaleFactor * scaleMultiplier) * Time.deltaTime;

        Player.Instance.catchedObjectPos.Translate(0, 0, -Player.Instance.scaleFactor * Time.deltaTime);

        transform.parent.localPosition = Vector3.zero;

    }

}
