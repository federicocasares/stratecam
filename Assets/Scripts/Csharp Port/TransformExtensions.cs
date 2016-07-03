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
            var vector = new Vector3();
            if (x != null) { vector.x = x.Value; }
            if (y != null) { vector.y = y.Value; }
            if (z != null) { vector.z = z.Value; }
            transform.localEulerAngles = vector;
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
            var vector = new Vector3();
            if (x != null) { vector.x = x.Value; }
            if (y != null) { vector.y = y.Value; }
            if (z != null) { vector.z = z.Value; }
            transform.position = vector;
        }
    }
}
