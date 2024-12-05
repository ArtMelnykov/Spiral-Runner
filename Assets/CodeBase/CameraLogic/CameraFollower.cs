using UnityEngine;

namespace CodeBase.CameraLogic
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField]
        private GameObject _player;
        
        private Vector3 _offset;

        void Start()
        {
            if (_player != null)
            {
                _offset = transform.position - _player.transform.position;
            }
            else
            {
                Debug.LogError("No player assigned!");
            }
        }

        void LateUpdate() => transform.position = _player.transform.position + _offset;
    }
}