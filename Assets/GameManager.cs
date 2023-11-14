using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Targets;
    public float spawnTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine((spawnRate()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnRate ()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);
                int index = Random.Range(0, Targets.Count);
            Instantiate(Targets[index]);
        }
    }
}
