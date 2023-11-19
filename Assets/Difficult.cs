using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;
public class Difficult : MonoBehaviour
{
    private GameManager gameManager;
    private Button button;
   
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setDifficulty()
    {
        gameManager.StartGame();
        Debug.Log(button.gameObject.name + "was clicked");
    }
    
}
