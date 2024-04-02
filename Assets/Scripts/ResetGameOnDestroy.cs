using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGameOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        //Reset scene when this gameobject is destroyed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
