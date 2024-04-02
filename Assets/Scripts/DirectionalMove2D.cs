using UnityEngine;

[Tooltip("Moves owning game object following a direction at given speed.")]
public class MoveInDirection2D : MonoBehaviour
{
    [Tooltip("Direction to move along")]
    public Vector2 _direction = Vector2.zero;
    [Tooltip("Movement speed")]
    public float _displacementSpeed = 5f;

    private Vector3 _movementDirection;

    private void Start()
    {
        _movementDirection = new Vector3(_direction.x, _direction.y, 0).normalized;
    }
    void Update()
    {
        //Apply MRU formula to move the object
        //REMEMBER: Multiplying by Time.deltaTime makes it time dependant not frame dependant
        transform.position += _movementDirection * _displacementSpeed * Time.deltaTime;
    }
}
