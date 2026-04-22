using UnityEngine;
using UnityEngine.UI;

public class LogButtons : MonoBehaviour
{
    // TAREA 1: Haz que este botón muestre un mensaje normal en consola (color blanco)
    public void ShowLogInfoMessage()
    {
       Debug.Log("Esto es un mensaje informativo para corroborar que el botón funciona bien.");
    }

    // TAREA 2: Haz que este botón muestre una ADVERTENCIA (triángulo amarillo)
    public void ShowLogWarningMessage()
    {
        Debug.LogWarning("Esto es un mensaje de Warning con un triángulo amarillo patito.");
    }

    // TAREA 3: Haz que este botón muestre un ERROR (octágono rojo)
    // PLUS: Investiga cómo hacer que Unity se PAUSE automáticamente al pulsar este botón.
    public void ShowLogErrorMessage()
    {
        Debug.LogError("Esto es un mensaje de 'todo mal loco, no puedo seguir así'.");
        Debug.Break();
    }
}
