using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAGameEscene : MonoBehaviour
{
    public void CambiarAGameEscene()
    {
        SceneManager.LoadScene("GAME scene");
    }
}