using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Targets;
    public float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine((spawnTarget()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    IEnumerator spawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
                int index = Random.Range(0, Targets.Count);
            Instantiate(Targets[index]);
        }
    }
}
