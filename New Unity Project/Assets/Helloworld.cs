using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    private int count = 0; //global variable

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello UCLA");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("update Hello UCLA" + count);
        int inc = 1; //local
        count = count + inc;
    }
}