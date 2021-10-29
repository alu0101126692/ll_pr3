using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objA : MonoBehaviour
{

    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        charController.Instance.OnContactA += mostrarTexto;
        texto.text = "Se ha colisionado con B, A mostro este mensaje";
        texto.enabled = false;
    }

    

    private void mostrarTexto() {
        texto.enabled = true;

        StartCoroutine(quitarMensaje());

    }

    private IEnumerator quitarMensaje() {
        yield return new WaitForSeconds(3);
        texto.enabled = false;
    }

    
}
