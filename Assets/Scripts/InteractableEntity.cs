using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class InteractableEntity : MonoBehaviour {

    public string InteractionText;

    public void ShowInteractionText()
    {
        GameManager.Instance.InteractionText.gameObject.SetActive(true);
        GameManager.Instance.InteractionText.text = InteractionText;
    }

    public void HideInteractionText()
    {
        GameManager.Instance.InteractionText.gameObject.SetActive(false);
        GameManager.Instance.InteractionText.text = string.Empty;
    }

}
