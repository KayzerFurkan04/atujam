using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languagemenu : MonoBehaviour
{
    int hangidilaktif;

    public GameObject oyna;
    public GameObject play;
    public GameObject ayarlar;
    public GameObject options;
    public GameObject credits;
    public GameObject yapýmcýlar;
    public GameObject quit;
    public GameObject çýkýþ;


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
        oyna.SetActive(false);
        play.SetActive(true);
        ayarlar.SetActive(false);
        options.SetActive(true);
        credits.SetActive(true);
        yapýmcýlar.SetActive(false);
        quit.SetActive(true);
        çýkýþ.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
        ;
    }

    public void turkbayrak()
    {
        oyna.SetActive(true);
        play.SetActive(false);
        ayarlar.SetActive(true);
        options.SetActive(false);
        credits.SetActive(false);
        yapýmcýlar.SetActive(true);
        quit.SetActive(false);
        çýkýþ.SetActive(true);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
