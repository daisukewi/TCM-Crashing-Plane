using UnityEngine;

public class ResetPositionOnExitScreen : MonoBehaviour
{
    [Tooltip("Shall we reset position to parent's position?")]
    public bool _resetToParentPosition = false;

    private Vector3 _initialPosition;
    void Start()
    {
        if (_resetToParentPosition && transform.parent != null)
            _initialPosition = transform.parent.position;
        else
            _initialPosition = transform.position;
    }

    void OnBecameInvisible()
    {
        transform.position = _initialPosition;
    }
}
