using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Metin : MonoBehaviour
{
    public TMP_Text text;
    public void OnEndEditText(string tox)
    {
        text.text = "Cevabýnýz : "+tox;
    }
}
