using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CrossWalkSound : MonoBehaviour
{
    private AudioSource crossWalkAlarm;
    private XRBaseInteractable interactable;

    void Start()
    {
        // AudioSource 및 XRBaseInteractable 가져오기
        crossWalkAlarm = GetComponent<AudioSource>();
        interactable = GetComponent<XRBaseInteractable>();

        // 클릭 이벤트 등록
        if (interactable != null)
        {
            interactable.onSelectEntered.AddListener(OnCubeClicked);
        }
    }

    private void OnCubeClicked(XRBaseInteractor interactor)
    {
        // 소리 재생
        if (crossWalkAlarm != null && !crossWalkAlarm.isPlaying)
        {
            crossWalkAlarm.Play();
        }
    }

    void OnDestroy()
    {
        // 이벤트 등록 해제
        if (interactable != null)
        {
            interactable.onSelectEntered.RemoveListener(OnCubeClicked);
        }
    }
}
