using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Knight,
    Wizard,
}

[System.Serializable]
public class Character
{
    public CharacterType Type;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get{return instance;}
    }

    public List<Character> characters = new List<Character>();
    public string PlayerName { get; set; }
    public Character Character { get; set; }

    private void Awake()
    {
        // instance�� ������� �ʰ� ���� ��ũ��Ʈ�� ������ instance�� �ٸ��ٸ�
        // => ���� instance�� �ִ°� ���� ��ũ��Ʈ�� �ٸ���
        if (instance != null && instance != this)
        {
            // ��ü ����� ����
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
