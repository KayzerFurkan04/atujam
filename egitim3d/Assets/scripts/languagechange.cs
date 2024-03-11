using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class languagechange : MonoBehaviour
{
    int hangidilaktif;
    int digersahnelericinhangidilaktif;

    public GameObject language;
    public GameObject dil;
    public GameObject müzik;
    public GameObject music;
    public GameObject grafik;
    public GameObject grafic;

    public GameObject low;
    public GameObject düþük;
    public GameObject medium;
    public GameObject orta;
    public GameObject high;
    public GameObject yüksek;

    public GameObject back;
    public GameObject geri;


    void Start()
    {
        hangidilaktif = PlayerPrefs.GetInt(nameof(hangidilaktif));

        if(hangidilaktif == 0)
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
        müzik.SetActive(false);
        music.SetActive(true);
        dil.SetActive(false);
        language.SetActive(true);
        grafic.SetActive(true);
        grafik.SetActive(false);

        düþük.SetActive(false);
        low.SetActive(true);
        orta.SetActive(false);
        medium.SetActive(true);
        high.SetActive(true);
        yüksek.SetActive(false);

        geri.SetActive(false);
        back.SetActive(true);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
;    }

    public void turkbayrak()
    {
        müzik.SetActive(true);
        music.SetActive(false);
        dil.SetActive(true);
        language.SetActive(false);
        grafic.SetActive(false);
        grafik.SetActive(true);

        low.SetActive(false);
        düþük.SetActive(true);
        medium.SetActive(false);
        orta.SetActive(true);
        yüksek.SetActive(true);
        high.SetActive(false);

        geri.SetActive(true);
        back.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
