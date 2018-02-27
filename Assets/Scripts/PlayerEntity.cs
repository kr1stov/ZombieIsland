using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Interactible"))
        {
            other.SendMessage("ShowInteractionText");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Interactible"))
        {
            other.SendMessage("HideInteractionText");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Interactible") && Input.GetButtonUp("Action"))
        {
            other.SendMessage("DoInteraction");
        }
    }
}
