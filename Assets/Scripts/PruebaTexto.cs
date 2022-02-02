using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PruebaTexto : MonoBehaviour
{
    public TextMeshProUGUI textoEditable;
    public Color colorTexto;
    
    void Start()
    {
        textoEditable.text = "Hola, soy Kat";
        textoEditable.color = colorTexto;
    }

    void Update()
    {
        
    }
}
