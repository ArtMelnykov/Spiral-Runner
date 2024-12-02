using System.Collections;
using TMPro;
using UnityEngine;

namespace CodeBase.Infrastructure.UI.MainMenu
{
    public class TextAnimation : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _button;
        private Color _buttonColor;

        void Start()
        {
            _buttonColor = _button.color;
            _buttonColor.a = 1;
            _button.color = _buttonColor;
            
            StartCoroutine(LoopFade());
        }

        private IEnumerator LoopFade()
        {
            while (true)
            {
                yield return FadeOut();

                yield return FadeIn();
                
            }
        }

        private IEnumerator FadeOut()
        {
            while (_buttonColor.a >= 0)
            {
                _buttonColor.a -= 0.04f;
                _button.color = _buttonColor;
                yield return new WaitForSeconds(0.05f);
            }
        }

        private IEnumerator FadeIn()
        {
            while (_buttonColor.a < 1)
            {
                _buttonColor.a += 0.05f;
                _button.color = _buttonColor;
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}