using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

public class Btnn : MonoBehaviour
{
    public GameObject AnketSonuc;
    public GameObject AnaEkran;
    public GameObject Anket;
    public TMP_Text Sayi;
    public int Donusum;
    public void Start()
    {
        AnaEkran.gameObject.SetActive(true);
        AnketSonuc.gameObject.SetActive(false);
        Anket.gameObject.SetActive(false);
    }
    public void CikisButon()
    {
        Application.Quit();
    }
    public void On_Value_Change(float deger)
    {
        deger = deger * 100;
        Donusum = deger.ConvertTo<int>();
        Sayi.text="Üretken Akademiyi 100 üzerinden "+Donusum.ToString() + " puan seviyorsunuz.";
    }
    public void Sonuc()
    {
        AnketSonuc.gameObject.SetActive(true);
        AnaEkran.gameObject.SetActive(false);
    }
    public void SonucClose()
    {
        AnaEkran.gameObject.SetActive(true);
        AnketSonuc.gameObject.SetActive(false);
    }

    public void AnketGiris()
    {
        AnaEkran.gameObject.SetActive (false);
        Anket.gameObject.SetActive(true);
    }
    public void AnketCikis()
    {
        AnaEkran.gameObject.SetActive(true) ;
        Anket.gameObject.SetActive(false) ;
    }
}
