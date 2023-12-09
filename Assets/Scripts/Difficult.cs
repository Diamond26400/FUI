using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;
public class Difficult : MonoBehaviour
{
    private GameManager gameManager;
    private Button button;
    public int Difficulty;


    // Start is called before the first frame update
   public  void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setDifficulty()
    {
            gameManager.StartGame(Difficulty);
            Debug.Log(button.gameObject.name + "was clicked");
    
    }
    
}
