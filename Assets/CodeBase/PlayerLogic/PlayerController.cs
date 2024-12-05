using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _playerRb;
        
        private const float JumpForce = 10f;
        
        private bool _isGrounded = true;

        void Start() => _playerRb = GetComponent<Rigidbody>();

        void Update() => Jump();

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                _isGrounded = true;
            }
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            {
                _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
                _isGrounded = false;
            }
        }
    }
}