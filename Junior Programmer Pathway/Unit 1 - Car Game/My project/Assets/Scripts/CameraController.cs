using System;
using UnityEngine;

    public class CameraController : MonoBehaviour
    {
        public Vector3 cameraPosition;
        public Transform player;

        private void LateUpdate()
        {
            transform.position = player.position + cameraPosition;
        }
    }
