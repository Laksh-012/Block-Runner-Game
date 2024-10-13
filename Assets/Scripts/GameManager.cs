using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    bool isEnd = false;
    public GameObject completeUI;

    public void endGame(){
        if(isEnd == false){
            isEnd = true;
            Invoke("restart", 2f);
        }
    }

    public void completeLevel(){
        completeUI.SetActive(true);
    }
    void restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
