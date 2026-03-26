using UnityEngine;
using UnityEngine.InputSystem;

public class Magnuseffectkick: MonoBehaviour
{
    public Vector3 kickpower;
    public float spinAmount = 1.0f;
    public float MagnusStrength = 0.5f;
    private Rigidbody _rb;
    private bool _isShoot = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !_isShoot)
        {
            _rb.AddRelativeForce(kickpower, ForceMode.Impulse);
            _rb.AddTorque(Vector3.up * spinAmount);
            _isShoot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!_isShoot) return;
        Vector3 velocity = _rb.linearVelocity;
        Vector3 spin = _rb.angularVelocity;
        Vector3 magnusForce = Vector3.Cross(spin, velocity);
        magnusForce *= MagnusStrength;
        _rb.AddForce(magnusForce);

    }

}
