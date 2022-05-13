using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dollarize : MonoBehaviour
{
    public float dollar = 117.25f;
    public float pesos;    
    public float dollarized;
    void Start()
    {
        Dollarization(pesos);
    }
    
    void Update()
    {
        
    }

    public void Dollarization(float _pesos)
    {
        dollarized = _pesos / dollar;
        dollarized = Mathf.Round(dollarized * 100.0f) * 0.01f;
        print(dollarized);
    }
}
