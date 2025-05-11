using UnityEngine;

[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public Sprite characterSprite;
    public float maxHealth;
    public float moveSpeed;
}
