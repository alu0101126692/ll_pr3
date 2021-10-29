using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirar : MonoBehaviour
{

    public charController delegado;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        delegado.acercadoA += mirarAObjeto;
        
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
    }


    private void mirarAObjeto() {
        transform.LookAt(player);
    }
}
