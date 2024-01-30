using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class Soru1 : MonoBehaviour
{
    public TMP_Text text;
    public void OnEndEditText(string tax)
    {
        text.text = "Adýnýz : "+tax;
    }
}
