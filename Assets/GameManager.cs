using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Targets;
    public float spawnRate = 1.0f;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOver;
    private int score;
   
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine((spawnTarget()));
        UpdateScore(0);
        GameOver.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnTarget()
    {
        while (true)
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

}
