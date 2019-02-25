using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{
    public class CubeRotator : MonoBehaviour
    {
        [Range(0, 15)]
        public float rotationSpeed = 4f;

        [Range(0, 15)]
        public float floatSpeed = 4f;
        [Range(0, 5)]
        public float floatAmplitude = 1f;

        Vector3 startingPostion;

        Vector3 randomAxis;

        float time = 0;
        float oldFloatSpeed; 

        private void Start()
        {
            startingPostion = transform.position;
            oldFloatSpeed = floatSpeed;

            randomAxis = Vector3.up;

            randomAxis = randomAxis.RandomNormalized();

        }

        private void Update()
        {
            time += Time.deltaTime;

            if (floatSpeed != oldFloatSpeed)
            {
                if (floatSpeed != 0)
                {
                    time = time * oldFloatSpeed / floatSpeed;
                }
                else
                {
                    time = 0;
                }
                oldFloatSpeed = floatSpeed;
            }

            Rotate();
            Float();
        }

        void Rotate()
        {
            transform.Rotate(randomAxis, rotationSpeed);
        }

        void Float()
        {
            transform.localPosition = startingPostion + floatAmplitude * Vector3.up * Mathf.Sin(time * floatSpeed);
        }
    }
}
