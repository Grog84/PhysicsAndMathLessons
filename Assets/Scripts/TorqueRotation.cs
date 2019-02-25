using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{
    [RequireComponent(typeof(Rigidbody))]
    public class TorqueRotation : MonoBehaviour
    {
        public float torqueAmount = 50f;

        Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            rb.AddTorque(transform.up * torqueAmount * Time.deltaTime);
        }
    }
}
