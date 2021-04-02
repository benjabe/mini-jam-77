using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JetpackController : MonoBehaviour
{
    [SerializeField] private float _forceStrength = 1.0f;
    [SerializeField] private float _relativeForceDirectionInDegrees = 0.0f;

    private Rigidbody2D _rigidBody;
    private bool _isPropelling;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _isPropelling = Input.GetButton("Jump");
    }

    private void FixedUpdate()
    {
        if (_isPropelling)
            _rigidBody.AddRelativeForce(CalculateForceVector());
    }

    private Vector2 CalculateForceVector()
    {
        var directionVector = new Vector2(
            Mathf.Cos(_relativeForceDirectionInDegrees * Mathf.Deg2Rad),
            Mathf.Sin(_relativeForceDirectionInDegrees * Mathf.Deg2Rad));
        return directionVector * _forceStrength;
    }
}
