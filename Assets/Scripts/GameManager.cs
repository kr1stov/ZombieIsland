using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    public static GameManager Instance = null;

    public Text InteractionText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
