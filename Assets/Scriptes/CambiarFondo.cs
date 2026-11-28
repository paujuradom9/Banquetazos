using UnityEngine;
using UnityEngine.UI;

public class CambiarFondo : MonoBehaviour
{
    public Image cuadroDelFondo; // Aquí arrastras tu única Image de la escena

    public void PonerCalle(Sprite imagenDeLaCalle)
    {
        cuadroDelFondo.sprite = imagenDeLaCalle;
    }
}