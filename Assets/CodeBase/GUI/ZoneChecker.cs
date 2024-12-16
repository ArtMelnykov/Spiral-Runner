using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.GUI
{
    public class ZoneChecker : MonoBehaviour
    {
        private Dictionary<string, int> _zoneEffects;

        private const string GreenZone = "GreenZone";
        private const string RedZone = "RedZone";
        private const string YellowZone = "YellowZone";

        private string _currentZone = "";

        private void Awake()
        {
            _zoneEffects = new Dictionary<string, int>()
            {
                { GreenZone, -10 },
                { RedZone, -10 },
                { YellowZone, -5 },
            };
        }

        private void Update()
        {
            // if (!string.IsNullOrEmpty(_currentZone))
            // {
            //     Debug.Log($"You touched {_currentZone}, effect: {_zoneEffects[_currentZone]} to curse");
            // }
        }

        private void OnTriggerEnter2D(Collider2D zoneIndicator)
        {
            if (_zoneEffects.ContainsKey(zoneIndicator.tag))
            {
                _currentZone = zoneIndicator.tag;   
            }
        }
    }
}