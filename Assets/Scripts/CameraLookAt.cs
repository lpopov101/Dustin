using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    private GameObject objectToLookAt;

    // Start is called before the first frame update
    void Start()
    {
        objectToLookAt = GameObject.FindGameObjectWithTag("cube");
        objectToLookAt.GetComponent<TestScript>().PrintShit();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objectToLookAt.transform);
    }
}
