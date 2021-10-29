using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objB : MonoBehaviour
{

    public charController delegado;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        delegado.OnContactB += addFuerza;
        delegado.acercadoA += cambiarColor;

        
    }

    private void addFuerza() {
        fuerza++;
    }

    private void cambiarColor() {
        Debug.Log("cambio");
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
    }
}
