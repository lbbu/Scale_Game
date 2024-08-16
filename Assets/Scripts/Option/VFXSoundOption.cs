using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VFXSoundOption : MonoBehaviour
{
    [SerializeField] Slider VFXSoundSlider;
    [SerializeField] TextMeshProUGUI VFXSoundValueText;


    private float previosValue;

    // Start is called before the first frame update
    void Start()
    {

        UpdateUI();

    }

    // Update is called once per frame
    void Update()
    {

        if (previosValue != VFXSoundSlider.value)
        {
            VFXSoundValueText.text = Mathf.Floor(VFXSoundSlider.value * 100).ToString();
            PlayerPrefs.SetFloat("VFXSoundValue", VFXSoundSlider.value);
        }
        previosValue = VFXSoundSlider.value;

    }

    private void UpdateUI()
    {

        float value = PlayerPrefs.GetFloat("VFXSoundValue");
        VFXSoundSlider.value = value;
        VFXSoundValueText.text = Mathf.Floor(VFXSoundSlider.value * 100).ToString();

    }
}
