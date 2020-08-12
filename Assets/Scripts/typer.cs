using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typer : MonoBehaviour
{
    public palavras palavras = null;
    public Text palavraOutput = null;
    public GameObject GameCanvas;
    public GameObject GameOverCanvas;

    private string palavraRestante = string.Empty;
    private string palavraAtual = string.Empty;
    
    private void Start()
    {
        SetPalavraAtual();
    }

    private void SetPalavraAtual()
    {
        palavraAtual = palavras.PegarPalavra();
        if (palavraAtual != string.Empty)
        {
            SetPalavraRestante(palavraAtual);

        }
        else
        {
            GameCanvas.SetActive(false);
            GameOverCanvas.SetActive(true);
        }
        

    }

    private void SetPalavraRestante(string newString)
    {
        palavraRestante = newString;
        palavraOutput.text = palavraRestante;

    }
  
    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
            {
                MostrarLetra(keysPressed);
            }
        }

    }

    private void MostrarLetra(string letra)
    {
        if (eLetraCorreta(letra))
        {
            RemoverLetra();

            if (ePalavraCompleta())
            {
                SetPalavraAtual();
            }
        }

    }

    private bool eLetraCorreta(string letra)
    {

        return palavraRestante.IndexOf(letra) == 0;
    }

    private void RemoverLetra()
    {
        string newString = palavraRestante.Remove(0, 1);
        SetPalavraRestante(newString);
    }

    private bool ePalavraCompleta()
    {
        return palavraRestante.Length==0;
    }
}
