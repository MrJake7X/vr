using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureHunt : MonoBehaviour
{
    public int totalPresent;
    private int presentsFounded;

    [SerializeField]
    private TextMeshProUGUI presentCount;

    void Start()
    {
        presentCount.text = presentsFounded + "/" + totalPresent;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Present"))
        {
            presentsFounded++;
            presentCount.text = presentsFounded + "/" + totalPresent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Present"))
        {
            presentsFounded--;
            presentCount.text = presentsFounded + "/" + totalPresent;
        }
    }
}
