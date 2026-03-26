using UnityEngine;
using UnityEngine.InputSystem;

public class AngulaVelocityControl : MonoBehaviour
{
    public float angulaspeed = 1f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            _rb.angularVelocity = new Vector3(0, angulaspeed, 0);

        }
        else
        {
            _rb.angularVelocity = Vector3.zero;
        }
    }
}
