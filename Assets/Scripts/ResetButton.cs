using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public GameObject ennemy;
    GameObject ennemyClone;

    bool flagCreate = false;
    bool flagArea = false;

    private void Start()
    {


    }
    private void Update()
    {
        if (flagArea)
        {
            if (Input.GetKey(KeyCode.E))
            {
                flagCreate = !flagCreate;
                if (flagCreate)
                {
                    Debug.Log("CREATE");
                    ennemyClone = Instantiate(ennemy, new Vector3(5f, 0f, -7f), Quaternion.identity);
                    ennemyClone.transform.rotation = new Quaternion(0, 0.5f, 0, 0);
                }
                else
                {
                    Debug.Log("DESTROY");
                    Destroy(ennemyClone);
                }

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        flagArea = true;
    }

    private void OnTriggerExit(Collider other)
    {
        flagArea = false;
    }
}
