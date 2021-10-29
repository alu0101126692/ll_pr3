using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirar : MonoBehaviour
{



    
    // Start is called before the first frame update
    void Start()
    {
        charController.Instance.acercadoA += mirarAObjeto;
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(transform.position, forward, Color.green);
    }


    private void mirarAObjeto() {
        transform.LookAt(charController.Instance.gameObject.transform);
    }
}
