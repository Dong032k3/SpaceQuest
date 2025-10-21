using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float worldSpeed = 2f;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
}
