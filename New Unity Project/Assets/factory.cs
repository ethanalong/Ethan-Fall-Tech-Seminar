using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
    public GameObject prefab;

    public GameObject Target;

    public float MakeRate = 2.0f;

    private float _lastMake = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _lastMake += Time.deltaTime; //_lastMkae = _lastMake + Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            Debug.Log("Make");

            GameObject go = Instantiate(prefab, this.transform.position, Quaternion.identity);
            MobileUnit mu = go.GetComponent<MobileUnit>();

            mu.Target = Target;
            _lastMake = 0; //reset time counter
        }
    }
}