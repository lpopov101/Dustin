using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0);
    }

    public void PrintShit()
    {
        Debug.Log("Hello, World!");
    }
}
