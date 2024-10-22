using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameState { Menu, Game, LevelComplete, Gameover }
    private GameState gamestate;

    public static Action<GameState> onGameStateChanged;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameState(GameState gameState)
    {
        this.gamestate = gameState;
        onGameStateChanged?.Invoke(gamestate);

        Debug.Log("Game State changed to : "+ gameState);
    }

    public bool IsGamestate()
    {
        return gamestate == GameState.Game;
    }
}
