using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;
    // attached to enemy
    public Vector3 originalPosition;
    public List<Vector3> nextPosition;
    public bool isTracking = false;

    float startTime;
    public void EnemyBorn()
    {
        StartCoroutine("StartTracking");
    }
    public void EnemyBorn(Vector3 position)
    {
        originalPosition = position;
        StartCoroutine("StartTracking");
    }
    IEnumerator StartTracking()
    {
        yield return new WaitForSeconds(0.5f);
        isTracking = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isTracking)
        {
            if (nextPosition.Count > 0)
            {
                transform.position = Vector3.Lerp(transform.position, nextPosition[0], speed*(Time.time-startTime));
                if (Vector3.Distance(transform.position, nextPosition[0]) < 0.05f)
                {
                    nextPosition.RemoveAt(0);
                    startTime = Time.time;
                }
            }
        }
    }
}
