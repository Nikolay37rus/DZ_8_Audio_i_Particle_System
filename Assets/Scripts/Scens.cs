using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scens : MonoBehaviour
{
    
  public void ChangeScenes(int numberScens) 
    {
        SceneManager.LoadScene(numberScens);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

