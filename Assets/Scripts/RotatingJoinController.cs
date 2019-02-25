using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{
    
    public class RotatingJoinController : MonoBehaviour
    {
        FixedJoint join;

        private void Start()
        {
            join = GetComponent<FixedJoint>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(join);
            }
        }
    }

}

