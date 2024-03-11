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
    public GameObject yap�mc�lar;
    public GameObject quit;
    public GameObject ��k��;


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
        yap�mc�lar.SetActive(false);
        quit.SetActive(true);
        ��k��.SetActive(false);

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
        yap�mc�lar.SetActive(true);
        quit.SetActive(false);
        ��k��.SetActive(true);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
