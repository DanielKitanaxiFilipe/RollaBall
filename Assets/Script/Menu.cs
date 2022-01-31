using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void menu (){
       SceneManager.LoadScene("menu");
   }
   public void Scene1 (){
       SceneManager.LoadScene("Scene1");
   }
   public void Scene2 (){
       SceneManager.LoadScene("Scene2");
   }
   public void Scene3 (){
       SceneManager.LoadScene("Scene3");
   }
    public void Scene4 (){
       SceneManager.LoadScene("Scene4");
   }
   public void Scene5 (){
       SceneManager.LoadScene("Scene5");
   }
   public void Scene6 (){
       SceneManager.LoadScene("Scene6");
   }
   public void Scene7 (){
       SceneManager.LoadScene("Scene7");
   }
   public void Scene8 (){
       SceneManager.LoadScene("Scene8");
   }
public void Termino (){
       SceneManager.LoadScene("termino");
   }

   public void QuitGame (){
       Application.Quit();
   }
}
