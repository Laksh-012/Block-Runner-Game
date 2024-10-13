using UnityEngine;

public class GameEnd : MonoBehaviour
{
   public GameManager gamemanager;
   public void LevelComplete(){
        gamemanager.completeLevel();
        
   }
}
