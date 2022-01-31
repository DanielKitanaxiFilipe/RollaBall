using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLockUnlock : MonoBehaviour
{
    int Levellock;
    public Button [] levelButtons;
    void Start()
    {
        Levellock = PlayerPrefs.GetInt ("Levellock",1);
        for (int i = 0; i < levelButtons.Length; i ++){
            levelButtons[i].interactable = false;
        }
        for(int i = 0 ; i < Levellock; i ++){
            levelButtons[i].interactable = true;
        }
    }

    // Update is called once per frame
    public void opnLevel (int levelIndex){
        SceneManager.LoadScene(levelIndex);
    }
}
