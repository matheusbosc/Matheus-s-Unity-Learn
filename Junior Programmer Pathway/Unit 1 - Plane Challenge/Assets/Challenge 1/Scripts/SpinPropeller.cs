using System;
using UnityEngine;

namespace Challenge_1.Scripts
{
    public class SpinPropeller : MonoBehaviour
    {
        public float speed = 100;
        private void Update()
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}