using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToplam : MonoBehaviour
{
    Text text;
    public static int skor;
    void Start()
    {
        text = GetComponent<Text>();
    }

   
    void Update()
    {
        text.text = skor.ToString();
    }
}
