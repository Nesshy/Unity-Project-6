using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class Soru2 : MonoBehaviour
{
    public TMP_Text text;
    public void OnEndEditText(string tex)
    {
        text.text ="Soyadýnýz : " +tex;
    }
}