using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandHider : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer;
    private XRDirectInteractor interactor;

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        interactor = GetComponent<XRDirectInteractor>();

        interactor.onHoverEntered.AddListener(Hide);
        interactor.onHoverExited.AddListener(Show);
    }

    private void OnDestroy()
    {
        interactor.onHoverEntered.RemoveListener(Hide);
        interactor.onHoverExited.RemoveListener(Show);
    }

    private void Show(XRBaseInteractable interactable)
    {

    }

    private void Hide(XRBaseInteractable interactable)
    {

    }
}
