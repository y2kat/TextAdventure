using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] palabrasGuardadas;
    [SerializeField] private string[] preguntas;
    [SerializeField] private string historia;
    [SerializeField] TextMeshProUGUI textoPreguntas;
    [SerializeField] TextMeshProUGUI textoHistoria;
    [SerializeField] TMP_InputField inputRespuesta;
    [SerializeField] GameObject botonRespuesta;

    int indicePregunta = 0;

    void Start()
    {
      
        textoPreguntas.text = preguntas[indicePregunta];
        //Debug.Log(preguntas.Length);
        //Debug.Log(palabrasGuardadas.Length);
        //palabrasGuardadas = new string[1];
        //palabrasGuardadas[0] = preguntas[0];
        palabrasGuardadas = new string[preguntas.Length];

    }
    public void GuardarRespuesta()
        {
        //guardar respuesta del jugador
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;
        //limpiar texto para que el jugador pueda escribir de nuevo
        inputRespuesta.text = "";
        //poner la siguiente pregunta
        indicePregunta++;
        //TODO necesitamos comprobación
        if(indicePregunta >= preguntas.Length)
        {
            //TODO si la comprobación es cierta ejecutar MostrarHistoria
            MostrarHistoria();
            //return;
        }
        else
        {
            textoPreguntas.text = preguntas[indicePregunta];
        }
    }

    void MostrarHistoria()
    {
        //TODO Mostrar un tmp que tenga toda la historia
        textoHistoria.gameObject.SetActive(true);
        textoHistoria.text = historia;
        //TODO ocultar elementos que no se utilizan
        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
    }
}
