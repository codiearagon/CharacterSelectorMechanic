using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public List<CharacterData> characterList = new List<CharacterData>();
    public CharacterData character;

    [SerializeField] private PlayerData playerData;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private Image characterImage;
    [SerializeField] private TextMeshProUGUI maxHealthText;
    [SerializeField] private TextMeshProUGUI moveSpeedText;

    private int currentIndex;

    void Start()
    {
        if (characterList[0] != null) 
        { 
            SetCharacter(characterList[0]);
            currentIndex = 0;
        }
        else
            Debug.Log("Character List is empty");
    }

    public void LeftButton()
    {
        if(currentIndex == 0)
            currentIndex = characterList.Count - 1;
        else
            currentIndex--;

        SetCharacter(characterList[currentIndex]);
    }

    public void RightButton()
    {
        if (currentIndex == characterList.Count - 1)
            currentIndex = 0;
        else
            currentIndex++;

        SetCharacter(characterList[currentIndex]);
    }

    public void StartButton()
    {
        playerData.character = character;
        SceneManager.LoadScene("Game");
    }

    private void SetCharacter(CharacterData c)
    {
        character = c;
        nameText.text = "Name: " + character.characterName;
        characterImage.sprite = character.characterSprite;
        maxHealthText.text = "Max Health: " + character.maxHealth.ToString();
        moveSpeedText.text = "Move Speed: " + character.moveSpeed.ToString();
    }
}
