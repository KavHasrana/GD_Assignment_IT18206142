using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ManagerScript : MonoBehaviour
{
    public Text score;
    public Text Health;

    int sc = 0;
    int hl = 3;

    void Start()
    {
        score.text = sc.ToString();
        Health.text = hl.ToString();
    }

    
}
