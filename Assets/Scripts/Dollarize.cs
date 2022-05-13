//En este proyecto se utilizan billetes argentinos como marcadores de RA. La imagen desplegada es la de un dolar. 
//Este Script se utiliza para convertir el valor del billete visualizado y reproducirlo sobre la imagen del dolar.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dollarize : MonoBehaviour
{
    public float dollar = 117.25f;
    public float pesos;    
    public float dollarized;

    public TextMeshPro[] textos;

    void Start()
    {
        textos = new TextMeshPro[gameObject.transform.childCount];
        textos = gameObject.GetComponentsInChildren<TextMeshPro>();

        
    }
    
    void Update()
    {
        Dollarization(pesos);
    }

    public void Dollarization(float _pesos)
    {
        dollarized = _pesos / dollar;
        dollarized = Mathf.Round(dollarized * 100.0f) * 0.01f;
        print(dollarized);

        for ( int i = 0 ; i < textos.Length ; i ++ )
        {
            textos[i].text = dollarized.ToString();
        }
    }
}
