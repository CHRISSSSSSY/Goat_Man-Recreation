using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    void Start()
    {
        SceneManager.sceneLoaded += LoadScene;
    }


    void Update()
    {

    }


    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }


    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


    public void LoadScene(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            GameObject.FindWithTag("QuitButton").GetComponent<Button>().onClick.AddListener(Quit);
        }
    }
}
