using UnityEngine;

namespace CodeBase.RopeLogic
{
    public class RopeRotate : MonoBehaviour
    {
        private Quaternion _initialRopeRotation;
        
        private readonly float _rotationSpeed = 29f;

        private const float MaxAngle = 40f;
        private const float MinAngle = -40f;

        private float _currentAngle = 0f;

        private int _direction = 1;

        private void Start() => 
            _initialRopeRotation = transform.localRotation;

        private void Update() => 
            Rotate();

        private void Rotate()
        {
            _currentAngle += _direction * _rotationSpeed * Time.deltaTime;

            if (_currentAngle >= MaxAngle || _currentAngle <= MinAngle)
            {
                _direction *= -1;
                
                _currentAngle = Mathf.Clamp(_currentAngle, MinAngle, MaxAngle);
            }
            
            Quaternion targetRotation = Quaternion.Euler(_currentAngle, 0f, 0f) * _initialRopeRotation;
            transform.localRotation = targetRotation;
        }
    }
}