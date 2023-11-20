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
      
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setDifficulty()
    {
            gameManager.StartGame();
            Debug.Log(button.gameObject.name + "was clicked");
    
    }
    
}
