using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languagecredits : MonoBehaviour
{
    int hangidilaktif;

    public GameObject tesekkur;
    public GameObject thanks;
    public GameObject geri;
    public GameObject back;


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
        tesekkur.SetActive(false);
        thanks.SetActive(true);
        geri.SetActive(false);
        back.SetActive(true);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
        ;
    }

    public void turkbayrak()
    {
        tesekkur.SetActive(true);
        thanks.SetActive(false);
        back.SetActive(false);
        geri.SetActive(true);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
