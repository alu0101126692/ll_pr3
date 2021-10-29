using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void Contact();

public class charController : MonoBehaviour
{
    public float speed;
	public float rotationSpeed;
	public int puntuacion = 0;
	private Vector3 movimiento;
	//public Text texto;


    public static charController controller;
    public event Contact OnContactA;
    public event Contact OnContactB;
    public event Contact acercadoA;


    public static charController Instance {
        get {
            return controller;
        }
    }

     private void Awake()
    {
        controller = this;
    }
   

    // Update is called once per frame
    void Update()
    {
      move();
			rotacion();
    }
	
	private void move() {
		movimiento = Vector3.zero;
		movimiento.x = (Input.GetAxis("Horizontal") * speed * Time.deltaTime);
		movimiento.z = Vector3.forward.z *Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		transform.Translate(movimiento);
		
	}
	
	private void rotacion() {
		float direccion = 0;
		direccion = Input.GetAxis("Fire1") * rotationSpeed;
		
		transform.Rotate(0, direccion * Time.deltaTime, 0);
	}


    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "ObjA") 
			OnContactB();
        if (col.gameObject.tag == "ObjB") 
			OnContactA();
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "ObjA") {
            acercadoA();
        }
    }
}
