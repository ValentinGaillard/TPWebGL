using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorEvent : MonoBehaviour
{
    public GameObject cube;
    public float smoothing = 1f;
    bool flagIn = false;

    private void Start()
    {
        StartCoroutine(ChangePositionObject(cube.transform));
    }

    private void OnTriggerEnter(Collider other)
    {
        flagIn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        flagIn = false;
    }


    private IEnumerator ChangePositionObject(Transform transform)
    {
        while (true)
        {
            if (flagIn)
            {
                Debug.Log("IN ENTER");
                Vector3 target = new Vector3(5.0f, 1.2f, -14.5f);
                while (Vector3.Distance(transform.position, target) > 0.05f)
                {
                    transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
                    yield return null;
                }
            }

            if (!flagIn)
            {
                Debug.Log("OUT");
                Vector3 target = new Vector3(5.0f, 1.2f, -13f);
                while (Vector3.Distance(transform.position, target) > 0.05f)
                {
                    transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
                    yield return null;
                }
            }
            yield return null;
        }
    }
}
