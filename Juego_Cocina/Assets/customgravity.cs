using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customgravity : MonoBehaviour
{
    public float gravity = -4.9f; // Valor de la gravedad personalizada (negativo para caída)
    private Vector3 velocity = Vector3.zero; // Velocidad acumulada

    void Update()
    {
        // Acumula velocidad basada en la gravedad
        velocity.y += gravity * Time.deltaTime;

        // Mueve el objeto basándose en la velocidad calculada
        transform.position += velocity * Time.deltaTime;

        // Opción: Limitar posición para evitar que atraviese el "suelo"
        if (transform.position.y <= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            velocity.y = 0; // Detén la caída
        }
    }
}
