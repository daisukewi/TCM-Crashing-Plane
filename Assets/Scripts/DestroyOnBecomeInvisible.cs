using UnityEngine;

public class DestroyOnBecomeInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
