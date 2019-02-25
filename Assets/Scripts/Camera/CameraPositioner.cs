using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{

    public class CameraPositioner : MonoBehaviour
    {
        public CameraPosition[] cameraPositions;

        Vector3 startingPosition;
        Quaternion startingRotation;

        private void Start()
        {
            startingPosition = transform.position;
            startingRotation = transform.rotation;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SetPosition(startingPosition, startingRotation);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SetPosition(cameraPositions[0]);
            }
        }

        void SetPosition(CameraPosition pos)
        {
            transform.position = pos.position;
            transform.rotation = Quaternion.Euler(pos.rotation);
        }

        void SetPosition(Vector3 pos, Quaternion rot)
        {
            transform.position = pos;
            transform.rotation =  rot;
        }


    }
}

