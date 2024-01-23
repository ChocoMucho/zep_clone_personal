using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Image chracterSprite;
    [SerializeField] private InputField inputField;
    private GameManager gameManager;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject characterSelect;

    private CharacterType Type;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    public void OnClickCharacter()
    {
        information.SetActive(false);
        characterSelect.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        Type = (CharacterType)index;
        Character character = gameManager.characters.Find(item => item.Type == Type);
        gameManager.Character = character;
        chracterSprite.sprite = character.CharacterSprite;
        chracterSprite.SetNativeSize();

        characterSelect.SetActive(false);
        information.SetActive(true);
    }

    public void OnClickJoin()
    {
        if (!(2 < inputField.text.Length && 10 > inputField.text.Length))
        {
            Debug.Log(inputField.text);
            return;
        }

        Debug.Log(inputField.text);
        gameManager.PlayerName = inputField.text;

        SceneManager.LoadScene("MainScene");
    }
}
