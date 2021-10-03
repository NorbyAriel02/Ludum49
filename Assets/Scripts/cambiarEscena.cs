using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        Debug.Log("HOLA MIGUEL!!!");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);        
    }

    public void Test()
    {
        Debug.Log("HOLA MIGUEL!!!");
    }

}
