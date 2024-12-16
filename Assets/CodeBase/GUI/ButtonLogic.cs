using System;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.GUI
{
    public class ButtonLogic : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private Button _button;
        
        public event Action OnButtonClicked;

        private void Start()
        {
            if (_button != null)
            {
                _button.onClick.AddListener(() =>
                    OnButtonClicked?.Invoke());
            }
        }

        private void OnDestroy()
        {
            if (_button != null)
            {
                _button.onClick.RemoveAllListeners();
            }
        }
    }
}