using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorPista : MonoBehaviour
{

    public GameObject imagenPista1;  
    public GameObject imagenPista2;  
    public GameObject imagenPista3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarPistaUno()
    {
         imagenPista1.SetActive(true);
    }

    public void OcultarPistaUno()
    {
         imagenPista1.SetActive(false);
    }

   public void MostrarPistaDos()
    {
         imagenPista2.SetActive(true);
    }

    public void OcultarPistaDos()
    {
         imagenPista2.SetActive(false);
    }

       public void MostrarPistaTres()
    {
         imagenPista3.SetActive(true);
    }

    public void OcultarPistaTres()
    {
         imagenPista3.SetActive(false);
    }
}
