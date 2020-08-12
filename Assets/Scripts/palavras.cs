using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class palavras : MonoBehaviour
{
    private List<string> palavrasOriginais = new List<string>()
    {
        "Eu","Gosto","De","Sorvete"
    };

    private List<string> palavrasJogo = new List<string>();

    private void Awake()
    {
        palavrasJogo.AddRange(palavrasOriginais);
        Shuffle(palavrasJogo);
        ConverterMinusculo(palavrasJogo);
    }

    private void Shuffle(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporario = list[i];

            list[i] = list[random];
            list[random] = temporario;
        }
    }

    private void ConverterMinusculo(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string PegarPalavra()
    {
        string palavraNova = string.Empty;
        if(palavrasJogo.Count != 0)
        {
            palavraNova = palavrasJogo.Last();
            palavrasJogo.Remove(palavraNova);
        }
        if(palavrasJogo.Count < 0)
        {
            return string.Empty;
        }
        return palavraNova;
    }

}
