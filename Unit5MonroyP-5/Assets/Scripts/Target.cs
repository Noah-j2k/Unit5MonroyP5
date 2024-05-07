using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTourqe = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-maxTourqe,maxTourqe), Random.Range(maxTourqe,maxTourqe), Random.Range(maxTourqe,maxTourqe), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);  
    }
    float RandomTorqe()
    {
        return Random.Range(-maxTourqe, maxTourqe);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
