using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Game Config", order = 51)]

public class GameConfig : ScriptableObject
{
    [SerializeField] private int _boardWidth;
    [SerializeField] private int _boardHeight;
    [SerializeField] private int _gameTime;
    [SerializeField] private int _gameSpeed;

    public int getBoardWidth => _boardWidth;
    public int getBoardHeight => _boardHeight;
    public int getGameTime => _gameTime;
    public int getGameSpeed => _gameSpeed;
}
