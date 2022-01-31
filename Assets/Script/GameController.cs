using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject painelNextLevel;
    public GameObject painelDead;
    public GameObject painelPause;
    public ParticleSystem particleNextLevel;
    void Start()
    {
        painelNextLevel.SetActive(false);
        painelDead.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {   
       
    }

    private void OnTriggerEnter(Collider other) {       
        if (other.gameObject.CompareTag("box")){
            other.gameObject.SetActive(false); 
            gameObject.SetActive(false);
            painelNextLevel.SetActive(true);
            particleNextLevel.Play();
            NextLevelLoock();
        } 
         if (other.gameObject.CompareTag("dead")){
            gameObject.SetActive(false);
            painelDead.SetActive(true);
        }              
    }

     public void pausee (){
        painelPause.SetActive (true);
        Time.timeScale = 0; 
     }
    public void Nextpause (){
        painelPause.SetActive (false);
        Time.timeScale = 1;
     }

     void NextLevelLoock(){
       int currentLevel = SceneManager.GetActiveScene().buildIndex;
       if (currentLevel >= PlayerPrefs.GetInt("Levellock")){
           PlayerPrefs.SetInt("Levellock", currentLevel);
       }
     }
}
