using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class helloTime : MonoBehaviour
{
    public float contagem;
    public string nomeCenario;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem > 0.0f){
            contagem -= 0.1f;
            contagem.ToString("F2");
        }else{
            SceneManager.LoadScene(nomeCenario);
        }
    }
}
