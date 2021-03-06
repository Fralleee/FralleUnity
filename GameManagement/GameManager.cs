﻿using Fralle;
using UnityEngine;

//Waiting
//Preparation
//Live
//Ended

public class GameManager : MonoBehaviour
{
  [SerializeField] GameData gameData;
  public GameEvent stateChange;
  
  void SetState(GameState state)
  {
    gameData.SetRulesFromState(state);
    gameData.timer.ResetCountdown(gameData.rules.countdown);
    gameData.timer.ResetRoundTime();
    stateChange.Raise();
  }

  void Start()
  {
    SetState(gameData.state);
    gameData.blueTeamData.MatchStart();
    gameData.orangeTeamData.MatchStart();
  }

  void Update()
  {
    SyncStateWithGameData();
    TickTimer();
  }

  void SyncStateWithGameData()
  {
    //if (gameData.state != fsm.State) SetState(gameData.state);
  }

  void TickTimer()
  {
    if (gameData.rules.applyToElapsedTime) gameData.timer.Tick(Time.deltaTime);
    if (gameData.rules.countdown > 0) gameData.timer.CountdownTick(Time.deltaTime);
    if (gameData.rules.useRoundTimer) gameData.timer.RoundTick(Time.deltaTime);
  }
}
