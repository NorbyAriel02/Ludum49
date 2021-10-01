using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpSuelo : MonoBehaviour
{
    public Vector3 positionDisplacement;
    private Vector3 positionOrigin;
    private float _timePassed;
    private void Start()
    {
        float randomDistance = Random.Range(-50f, 50f);
        //positionDisplacement = new Vector3(0, 0, 2);
        positionOrigin = transform.position;
    }

    private void Update()
    {
        _timePassed += Time.deltaTime;
        transform.position = Vector3.Lerp(positionOrigin, positionOrigin + positionDisplacement,
            Mathf.PingPong(_timePassed, 1));
    }
}
