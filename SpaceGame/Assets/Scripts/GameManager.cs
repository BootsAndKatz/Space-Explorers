using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameState state;

    void Awake()
    {
        instance = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.Playing:
                break;
            case GameState.GameOver:
                HandleGameOverState();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

    }

    void HandleGameOverState()
    {
        
    }

    public enum GameState
    {
        Playing,
        GameOver

    }
}
