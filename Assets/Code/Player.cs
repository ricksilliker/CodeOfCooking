using System;
using UnityEngine;

namespace Code
{
    public class Player : MonoBehaviour
    {
        [Serializable]
        public enum PlayerType
        {
            Winston,
            Ren
        }
        
        
        [SerializeField] private Backpack backpack;
        [SerializeField] private Shield shield;
        [SerializeField] private GameObject ren;
        [SerializeField] private GameObject winston;

        private PlayerType _activePlayer;
    }
}