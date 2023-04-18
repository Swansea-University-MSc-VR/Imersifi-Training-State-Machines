using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class UIVolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private string audioMixerExposedVariable;

    public void setVolume(float sliderValue)
    {
        // Lerp between the default min and max vlaues for mixer volumes
        
        float mixerVal = Mathf.Lerp(-80f, 20f, sliderValue);

        audioMixer.SetFloat(audioMixerExposedVariable, mixerVal);
    }

}
