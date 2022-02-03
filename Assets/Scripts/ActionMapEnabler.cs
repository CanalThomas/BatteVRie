using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ECNBaseCode.Sample
{
    public class ActionMapEnabler : MonoBehaviour
    {
        [SerializeField]
        InputActionAsset m_ActionAsset;
        public InputActionAsset actionAsset
        {
            get => m_ActionAsset;
            set => m_ActionAsset = value;
        }

        private void OnEnable()
        {
            if (m_ActionAsset != null)
            {
                m_ActionAsset.Enable();
            }
        }
    }
}