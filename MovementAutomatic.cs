using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour
{

    [SerializeField] private float vel;

    [SerializeField] private Transform contSuelo;

    [SerializeField] private float dist;

    [SerializeField] private bool movDerecha;

    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        RaycastHit2D informacionSuelo = Physics2D.Raycast(contSuelo.position, Vector2.down, dist);

        rb.velocity = new Vector2 (vel, rb.velocity.y);

        if (informacionSuelo == false){
            Girar();
        }
    }

    private void Girar(){
        movDerecha = !movDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        vel *= -1
    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(contSuelo.transform.position, contSuelo.transform.position + Vector3.down * dist);
    }
}