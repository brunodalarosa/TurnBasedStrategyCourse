using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class MouseWorld : MonoBehaviour
    {
        public static MouseWorld Instance { get; set; }

        [field: SerializeField] private LayerMask MousePlaneLayer { get; set; }


        private void Awake()
        {
            Instance = this;
        }

        private void Update()
        {
            transform.position = GetPosition();
        }

        public static Vector3 GetPosition()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out var raycastHit, float.MaxValue, Instance.MousePlaneLayer);

            return raycastHit.point;
        }
    }
}