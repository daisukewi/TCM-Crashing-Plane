using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AddImpulse2D : MonoBehaviour
{
    [Tooltip("Direction of the applied impulse. Will be normalized.")]
    public Vector2 _direction = Vector2.up;
    [Tooltip("Magnitude of the impulse.")]
    public float _impulse = 10f;

    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.anyKeyDown)
            _rigidbody2D.AddForce(_direction.normalized * _impulse, ForceMode2D.Impulse);
    }
}
