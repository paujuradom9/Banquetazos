using UnityEngine;
using UnityEngine.UI;

public class CursorEscenario : MonoBehaviour
{
    [Header("Cursor y fondo")]
    public RectTransform flecha;          // Arrastra aquí "flecha" desde Hierarchy
    public Image cuadroFondo;           // Arrastra aquí "calle ana" (o tu Image de fondo)

    [Header("Opciones en orden de arriba a abajo")]
    public RectTransform[] posicionesBotones; // Pon aquí los 4 botones en orden
    public Sprite[] fondosCalles;             // Pon aquí los 4 sprites en el mismo orden

    [Header("Controles")]
    public KeyCode teclaSubir = KeyCode.W;
    public KeyCode teclaBajar = KeyCode.S;
    [Header("Ajuste de posición")]
    public float separacionX = -150f;
    private int indiceActual = 0;

    void Start()
    {
        ActualizarSeleccion();
    }

    void Update()
    {
        if (posicionesBotones == null || posicionesBotones.Length == 0) return;

        if (Input.GetKeyDown(teclaBajar) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            indiceActual = (indiceActual + 1) % posicionesBotones.Length;
            ActualizarSeleccion();
        }
        else if (Input.GetKeyDown(teclaSubir) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            indiceActual = (indiceActual - 1 + posicionesBotones.Length) % posicionesBotones.Length;
            ActualizarSeleccion();
        }
    }

    // También puedes llamar esto desde el On Click () de cada botón si quieres que funcione con clic o mouse
    public void SeleccionarIndice(int nuevoIndice)
    {
        if (posicionesBotones == null || nuevoIndice < 0 || nuevoIndice >= posicionesBotones.Length) return;
        indiceActual = nuevoIndice;
        ActualizarSeleccion();
    }

    private void ActualizarSeleccion()
    {
        if (flecha != null && posicionesBotones[indiceActual] != null)
        {
            Vector3 pos = posicionesBotones[indiceActual].position;
            flecha.position = new Vector3(pos.x + separacionX, pos.y, pos.z);
        }

        if (cuadroFondo != null && fondosCalles != null && indiceActual < fondosCalles.Length && fondosCalles[indiceActual] != null)
        {
            cuadroFondo.sprite = fondosCalles[indiceActual];
        }
    }
}