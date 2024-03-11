using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languageeasyhard : MonoBehaviour
{
    int hangidilaktif;

    public GameObject easy;
    public GameObject kolay;
    public GameObject medium;
    public GameObject orta;
    public GameObject zor;
    public GameObject hard;
    public GameObject back;
    public GameObject geri;


    void Start()
    {
        hangidilaktif = PlayerPrefs.GetInt(nameof(hangidilaktif));

        if (hangidilaktif == 0)
        {
            turkbayrak();
        }
        else
        {
            ingbayrak();
        }
    }

    public void ingbayrak()
    {
        easy.SetActive(true);
        kolay.SetActive(false);
        medium.SetActive(true);
        orta.SetActive(false);
        zor.SetActive(false);
        hard.SetActive(true);
        back.SetActive(true);
        geri.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void turkbayrak()
    {
        easy.SetActive(false);
        kolay.SetActive(true);
        medium.SetActive(false);
        orta.SetActive(true);
        zor.SetActive(true);
        hard.SetActive(false);
        back.SetActive(false);
        geri.SetActive(true);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
