using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.GUI
{
    public class CurseFilling : MonoBehaviour
    {
        private const float CurseUnit = 0.0001f;
        private const float MaxValue = 0.5f;

        private Image _curseValue;
        
        private void Start() => 
            _curseValue = GetComponent<Image>();

        private void Update()
        {
            if (_curseValue.fillAmount < MaxValue)
            {
                StartCoroutine(FillCurse());
            }
        }

        private IEnumerator FillCurse()
        {
            while (_curseValue.fillAmount < MaxValue)
            {
                _curseValue.fillAmount += CurseUnit;
                
                yield return new WaitForSeconds(5f);
            }
        }
    }
}