using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public Text coins;
    public int coinCount = 6;
    public bool pressed = false;
    public int buttons = 2;
    public EndTrigger endt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins Left: " + coinCount.ToString();
    }

    public void subtractCoin()
    {
        coinCount--;
        if (coinCount == 0)
        {
            endt.activateObject();
        }
    }

    void resetScene()
    {
        SceneManager.LoadScene("Production_Scene");
    }

    public void buttonPressed()
    {
        buttons--;
        if (buttons == 0)
        {
            pressed = true;
        }
    }
}
