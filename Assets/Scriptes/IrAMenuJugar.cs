using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAMenuJugar : MonoBehaviour
{
    public void CambiarAMenuJugar()
    {
        SceneManager.LoadScene("Menu Jugar");
    }
}