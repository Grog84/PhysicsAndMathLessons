using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{
    public class SimpleRotation : MonoBehaviour
    {
        [Range(0, 10)]
        public float rotationSpeed = 1f;

        private void Update()
        {
            Rotate();
        }

        void Rotate()
        {
            transform.Rotate(Vector3.up, rotationSpeed);
        }
    }
}

