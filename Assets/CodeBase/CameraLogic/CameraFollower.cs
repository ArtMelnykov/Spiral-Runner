using UnityEngine;

namespace CodeBase.CameraLogic
{
    public class CameraFollower : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private GameObject _player;
        
        private Vector3 _offsetPosition;

        private void Start()
        {
            if (_player != null)
            {
                _offsetPosition = transform.position - _player.transform.position;
            }
            else
            {
                Debug.LogError("No player assigned!");
            }
        }

        private void LateUpdate() =>
            FollowPlayer();

        private void FollowPlayer() => 
            transform.position = _player.transform.position + _offsetPosition;
    }
}