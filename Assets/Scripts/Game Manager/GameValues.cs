using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameValues : MonoBehaviour
{

    public static GameValues Instance { get; private set; }

    [HideInInspector] public float musicSoundValue;
    [HideInInspector] public float VFXSoundValue;


    private void Awake()
    {
        Instance = this;

    }

    private void Start()
    {
        UpdateValues();
    }

    public void UpdateValues()
    {

        musicSoundValue = PlayerPrefs.GetFloat("MusicSoundValue");
        VFXSoundValue = PlayerPrefs.GetFloat("VFXSoundValue");

    }


    public void UpdateMusicSoundValue()
    {
        musicSoundValue = PlayerPrefs.GetFloat("MusicSoundValue");
    }

    public void UpdateVFXSoundValue()
    {
        VFXSoundValue = PlayerPrefs.GetFloat("VFXSoundValue");
    }


}
