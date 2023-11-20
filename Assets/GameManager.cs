using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Targets;
    public GameObject TitleScreen;
    public float spawnRate = 1.0f;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOver;
    private int score;
    public bool IsgameActive;
   
 
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnTarget()
    {
        while (IsgameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, Targets.Count);
            Instantiate(Targets[index]);
         
        }
    }
    public void UpdateScore (int ScoreToUpdate)
    {
        score += ScoreToUpdate;
        ScoreText.text = "Score: " + score;
    }
    public void Gameover()
    {
        
        IsgameActive = false;
        GameOver.gameObject.SetActive(true);
    }
    public void StartGame()
    {
        StartCoroutine((spawnTarget()));
        UpdateScore(0);
        score = 0;
        IsgameActive = true;
    }


}
