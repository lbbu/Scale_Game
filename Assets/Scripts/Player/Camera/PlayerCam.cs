using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{

    public static PlayerCam Instance;

    private bool ableToMoveCamer = true;

    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    public Transform orientation;

    private float xRotation;
    private float yRotation;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        ableToMoveCamer = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void AbleCamerToMove()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameValues.Instance.ableToDoAnyThing = true;

    }

    public void DisAbleCamerToMove()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        GameValues.Instance.ableToDoAnyThing = false;

    }

    // Update is called once per frame
    void Update()
    {

        if(!GameValues.Instance.ableToDoAnyThing)
            return;

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        //rotate orientation and cam

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0); 
        //orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        Player.Instance.transform.rotation = Quaternion.Euler(0, yRotation, 0);

    }

}
