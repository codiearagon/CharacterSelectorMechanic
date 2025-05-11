using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public CharacterData character;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            return;

        DontDestroyOnLoad(Instance);
    }
}
