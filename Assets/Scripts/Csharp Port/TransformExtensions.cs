using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityEngine.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Updates the local eulerAngles to a new vector3, if a value is omitted then the old value will be used.
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public static void SetLocalEulerAngles(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var newVector = new Vector3();
            var oldVector = transform.localEulerAngles;
            newVector.x = x != null ? x.Value : oldVector.x;
            newVector.y = y != null ? y.Value : oldVector.y;
            newVector.z = z != null ? z.Value : oldVector.z;
            transform.localEulerAngles = newVector;
        }

        /// <summary>
        /// Updates the position to a new vector3, if a value is omitted then the old value will be used.
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public static void SetPosition(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var newVector = new Vector3();
            var oldVector = transform.position;
            newVector.x = x != null ? x.Value : oldVector.x;
            newVector.y = y != null ? y.Value : oldVector.y;
            newVector.z = z != null ? z.Value : oldVector.z;
            transform.position = newVector;
        }
    }
}
