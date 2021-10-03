using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCheckpoint : MonoBehaviour
{
    public GameObject flag;
    Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void update()
    {
        if (gameObject.transform.position.y < -5f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            spawnPoint = flag.transform.position;
            Debug.Log("checkpoint agarrado");
        }
    }
}
