using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    [SerializeField] GameObject botonReinicio;

    int indicePregunta = 0;

    void Start()
    {
      
        textoPreguntas.text = preguntas[indicePregunta];
        palabrasGuardadas = new string[preguntas.Length];

        botonReinicio.SetActive(false);

    }
    public void GuardarRespuesta()
        {
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;
        inputRespuesta.text = "";
        indicePregunta++;
        if(indicePregunta >= preguntas.Length)
        {
            MostrarHistoria();
        }
        else
        {
            textoPreguntas.text = preguntas[indicePregunta];
        }
    }

    void MostrarHistoria()
    {
        textoHistoria.gameObject.SetActive(true);
        textoHistoria.text = string.Format(historia, palabrasGuardadas);
        botonReinicio.SetActive(true);

        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
    }

    public void ReiniciarJuego()
    {
        int indexEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexEscena);
    }
}
