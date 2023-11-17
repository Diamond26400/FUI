using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    public ParticleSystem ExplosionP;
    private GameManager gameManager;

    private float minSpeed = 12.0f;
    private float maxSpeed = 16.0f;
    private float xRange = 4.0f;
    private float yRange = 2.0f;
    private float torqueMax = 10.0f;

    public int pointValue;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorue(), RandomTorue(), RandomTorue());

        transform.position = SpawnPos();
       
        
    }

    // Update is called once per frame
    void Update()
    {

       
    }
   private void OnMouseDown()
    {
        Instantiate(ExplosionP, transform.position, ExplosionP.transform.rotation);
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue);
        Debug.Log("key is being presseed");
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    Vector3 RandomForce ()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
   float RandomTorue ()
    {
        return Random.Range(-torqueMax, torqueMax);
    }
    Vector3 SpawnPos ()
    {
        return new Vector3(Random.Range(-xRange, xRange), -yRange);
    }
}
