using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float Velocidad = 1.0f;
    private Rigidbody2D rb2d;
    public GameObject objetoACrear;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector2 move = Vector2.zero;
        if (Input.GetButton("Derecha"))
        {
            move.x = 1;
            gameObject.GetComponent<Animator>().SetBool("run", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetButton("Izquierda"))
        {
            move.x = -1;
            gameObject.GetComponent<Animator>().SetBool("run", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetButton("Arriba"))
        {
            move.y = 1;
        }
        if (Input.GetButton("Abajo"))
        {
            move.y = -1;
        }
        if (Input.GetButtonUp("Disparar"))
        {
            Instantiate(objetoACrear, transform.position, transform.rotation);
        }
            rb2d.MovePosition((Vector2)this.transform.position + (move * Velocidad * Time.deltaTime)); 

        if (!Input.GetButton("Derecha") && !Input.GetButton("Izquierda"))
        {
            gameObject.GetComponent<Animator>().SetBool("run", false);
        }
            
    }
}
