using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Soru3 : MonoBehaviour
{
    public TMP_Text text;
    public void OnEndEditText(string tix)
    {
        text.text ="Telefon no : " +tix;
    }
}
