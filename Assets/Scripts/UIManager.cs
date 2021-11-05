using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }
}

