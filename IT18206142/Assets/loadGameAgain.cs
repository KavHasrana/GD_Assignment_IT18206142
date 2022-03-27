using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGameAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNewGame", 1.5f);
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene("Level_1");
    }

}
