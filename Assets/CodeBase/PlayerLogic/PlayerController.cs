using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _playerRb;
        
        private const float JumpForce = 10f;
        private const string Ground = "Ground";

        public bool IsGrounded = true;

        private void Start() => 
            _playerRb = GetComponent<Rigidbody>();

        private void Update() => 
            Jump();

        private void OnCollisionEnter(Collision ground)
        {
            if (ground.gameObject.CompareTag(Ground))
            {
                IsGrounded = true;                        
            }
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
            {
                _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
                IsGrounded = false;
            }
        }
    }
}