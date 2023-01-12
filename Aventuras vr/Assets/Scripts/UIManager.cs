using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI movementText;

    [SerializeField]
    private ActionBasedContinuousMoveProvider moveProvider;
    [SerializeField]
    private ActionBasedControllerManager teleportManager;
    [SerializeField]
    private GameObject teleportObject;

    private bool movementType;

    void Start()
    {
        
    }

    public void ChangeMovement()
    {
        if(movementType)
        {
            // Movement is teleport
            movementText.text = "Teleportación";
            movementType = !movementType;
            
            SetTeleport();
        }
        else
        {
            // Movement is free movement
            movementText.text = "Movimiento libre";
            movementType = !movementType;

            SetFreeMovement();
        }
    }

    private void SetFreeMovement()
    {
        moveProvider.enabled = true;
        teleportManager.enabled = false;
        teleportObject.SetActive(false);
    }

    private void SetTeleport()
    {
        teleportManager.enabled = true;
        teleportObject.SetActive(true);
        moveProvider.enabled = false;
    }
    
}
