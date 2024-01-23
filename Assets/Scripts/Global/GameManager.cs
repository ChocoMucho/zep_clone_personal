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
        // instance가 비어있지 않고 현재 스크립트가 기존의 instance와 다르다면
        // => 지금 instance에 있는게 지금 스크립트랑 다르면
        if (instance != null && instance != this)
        {
            // 객체 재생성 막음
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
