using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInitialize : MonoBehaviour
{
    public Text playerName;
    public Animator animator; 

    private void Awake()
    {
        playerName = GetComponentInChildren<Text>();
        animator = GetComponentInChildren<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = GameManager.Instance.PlayerName;
        animator.runtimeAnimatorController = GameManager.Instance.Character.AnimatorController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
