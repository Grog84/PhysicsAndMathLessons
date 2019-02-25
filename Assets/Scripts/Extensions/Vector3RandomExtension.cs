using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathAndPhys
{
    public static class Vector3RandomExtension
    {
        public static Vector3 RandomNormalized(this Vector3 parent)
        {
            parent.Set(Random.value, Random.value, Random.value);
            return parent.normalized;
        }
    }
}
