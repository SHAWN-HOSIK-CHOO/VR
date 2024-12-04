using System;
using UnityEngine;

namespace HoSik
{
    public class XROriginPlayerFollower : MonoBehaviour
    {
        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        void Update()
        {
            Transform cameraTransform = _mainCamera.transform;

            // 카메라의 월드 이동량 계산 (y축 제외)
            Vector3 movement = new Vector3(cameraTransform.position.x - transform.position.x, 0, cameraTransform.position.z - transform.position.z);

            // XR Origin 이동
            transform.position += movement;
        }


    }
}
