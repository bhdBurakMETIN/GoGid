using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _orientationTransform;
    [SerializeField] private Transform _playerVisualTransform;

    private void Update() 
    {
        Vector3 viewDirection = _playerTransform.position - new Vector3(transform.position.x, _playerTransform.position.y, transform.position.z);

        _orientationTransform.forward = viewDirection.normalized;
    }

    float horizontalInput = Input.GetAxisRaw("Horizontal");
    float verticalInput = Input.GetAxisRaw("Vertical");

    Vector3 inputDirection = _orientationTransform.forward * verticalInput + _orientationTransform.right * horizontalInput;
}

