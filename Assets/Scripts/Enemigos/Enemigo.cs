using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Atributos atributos;
    public string nombre;
    public int experiencia;

    public Atributos Atributos()
    {
        return atributos;
    }

    public void EntregarExperiencia()
    {
        GameManager.instance.jugador.GetComponent<NivelDeExperiencia>().experiencia += experiencia;
    }

}
