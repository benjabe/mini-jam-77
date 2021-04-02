using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TorqueController : MonoBehaviour
{
    [SerializeField] private float _torqueStrength = 1.0f; 

    private Rigidbody2D _rigidBody;
    private float _torque;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _torque = Input.GetAxis("Horizontal") * _torqueStrength;
    }

    private void FixedUpdate()
    {
        _rigidBody.AddTorque(_torque);
    }
}
