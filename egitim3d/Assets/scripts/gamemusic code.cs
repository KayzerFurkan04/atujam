using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class gamemusiccode : MonoBehaviour
{
    public AudioMixer audiomix;
    public Slider sesbar;

    void Start()
    {
        sesbar.value = PlayerPrefs.GetFloat("gamemusic");
    }

    public void gamemusic(float volume)
    {
        audiomix.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("gamemusic", sesbar.value);
    }
}
