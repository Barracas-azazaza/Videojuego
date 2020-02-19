using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPrueba : MonoBehaviour
{
    private string nombres;
    private string apellidos;
    private string colorOjos;
    private string colorPiel;
    private string sexo;
    private string raza;
    private float edad;
    private float altura;
    private float peso;
    private float largoPie;
    private float anchura;
    private float tiempoEstudiandoEnAños;
    private int tamañoCalzado;
    private int cantidadHermanos;
    private int cantidadPapas;
    private int deportesPracticados;
    private int carrerasTerminadas;
    private int promocion;
    private bool estadoEmpleado;
    private bool dramatico = true;
    private bool frio = true;
    private bool agradecido = true;
    private bool organizado = false;
    private bool honrado = true;
    // Start is called before the first frame update
    void Start()
    {
        mostrar_nombres();
        mostrar_apellidos();
        mostrar_colorOjos();
        mostrar_colorPiel();
        mostrar_sexo();
        mostrar_raza();
        mostrar_edad();
        mostrar_altura();
        mostrar_peso();
        mostrar_largoPie();
        mostrar_anchura();
        mostrar_tiempoEstudiandoEnAños();
        mostrar_tamañoCalzado();
        mostrar_cantidadHermanos();
        mostrar_cantidadPpas();
        mostrar_deportesPracticados();
        mostrar_carrerasTerminadas();
        mostrar_promocion();
        mostrar_estadoEmpleado();
        mostrar_dramatico();
        mostrar_frio();
        mostrar_agradecido();
        mostrar_organizado();
        mostrar_honrado();
        Debug.Log(nombres);
        Debug.Log(apellidos);
        Debug.Log(colorOjos);
        Debug.Log(colorPiel);
        Debug.Log(sexo);
        Debug.Log(raza);
        Debug.Log(edad);
        Debug.Log(altura);
        Debug.Log(peso);
        Debug.Log(largoPie);
        Debug.Log(anchura);
        Debug.Log(tiempoEstudiandoEnAños);
        Debug.Log(tamañoCalzado);
        Debug.Log(cantidadHermanos);
        Debug.Log(cantidadPapas);
        Debug.Log(deportesPracticados);
        Debug.Log(carrerasTerminadas);
        Debug.Log(promocion);
        Debug.Log(estadoEmpleado);
        Debug.Log(dramatico);
        Debug.Log(frio);
        Debug.Log(agradecido);
        Debug.Log(organizado);
        Debug.Log(honrado);
    }
    void mostrar_nombres()
    {
        nombres = "Nicolás";
    }
    void mostrar_apellidos()
    {
        apellidos = "Menjura Luque";
    }
    void mostrar_colorOjos()
    {
        colorOjos = "Verdes";
    }
    void mostrar_colorPiel()
    {
        colorPiel = "trigeño";
    }
    void mostrar_sexo()
    {
        sexo = "masculino";
        if (sexo == "masculino")
        {
            Debug.Log("Es hombre");
        }
        else
        {
            Debug.Log("Es mujer");
        }
    }
    void mostrar_raza()
    {
        raza = "llanero";
    }
    void mostrar_edad()
    {
        edad = 20.4f;
        if (edad < 18)
        {
            Debug.Log("Menor de edad");
        }
        else
        {
            Debug.Log("Mayor de edad");
        }
    }
    void mostrar_altura()
    {
        altura = 1.82f;
    }
    void mostrar_peso()
    {
        peso = 75.1f;
    }
    void mostrar_largoPie()
    {
        largoPie = 27.2f;
    }
    void mostrar_anchura()
    {
        anchura = 1.83f;
    }
    void mostrar_tiempoEstudiandoEnAños()
    {
        tiempoEstudiandoEnAños = 1.5f;
    }
    void mostrar_tamañoCalzado()
    {
        tamañoCalzado = 41;
    }
    void mostrar_cantidadHermanos()
    {
        cantidadHermanos = 4;
    }
    void mostrar_cantidadPpas()
    {
        cantidadPapas = 2;
    }
    void mostrar_deportesPracticados()
    {
        deportesPracticados = 2;
    }
    void mostrar_carrerasTerminadas()
    {
        carrerasTerminadas = 0;
    }
    void mostrar_promocion()
    {
        promocion = 6;
    }
    void mostrar_estadoEmpleado()
    {
        estadoEmpleado = true;
    }
    void mostrar_dramatico()
    {
        dramatico = true;
    }
    void mostrar_frio()
    {
        frio = true;
    }
    void mostrar_agradecido()
    {
        agradecido = true;
    }
    void mostrar_organizado()
    {
        organizado = false;
    }
    void mostrar_honrado()
    {
        honrado = true;
    }
    // Update is called once per frame
    void Update()
    {
    }
}