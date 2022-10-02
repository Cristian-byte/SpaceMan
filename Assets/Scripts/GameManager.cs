using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour{

    public GameState currentGameState = GameState.menu;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    //Iniciar juego
    public void StartGame(){

    }

    //Acabar juego
    public void GameOver(){

    }

    //Regresar al menu
    public void BackToMenu(){

    }

    private void SetGameState(GameState newGameState){
        if (newGameState == GameState.menu){
            //TODO: colocar la logica del menu
        } else if (newGameState == GameState.inGame){
            //TODO: hay que preparar la escena para jugar
        } else if(newGameState == GameState.gameOver){
            //TODO: preparar el juego para el game over
        }

        this.currentGameState = newGameState;
    }
}
