using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPausaEscena : MonoBehaviour
{
    [Header("Escena")]
    public string nombreEscenaPausa = "Pausa";

    [Header("Audio opcional")]
    public AudioSource audioSource;
    public AudioClip sonidoClick;
    public float esperaSegundos = 0.2f;

    public void IrAPausa()
    {
        Time.timeScale = 1f;
        StartCoroutine(CargarEscenaPausa());
    }

    private IEnumerator CargarEscenaPausa()
    {
        if (audioSource != null && sonidoClick != null)
        {
            audioSource.PlayOneShot(sonidoClick);
        }

        if (esperaSegundos > 0f)
        {
            yield return new WaitForSecondsRealtime(esperaSegundos);
        }

        if (!string.IsNullOrEmpty(nombreEscenaPausa))
        {
            SceneManager.LoadScene(nombreEscenaPausa);
        }
    }
}