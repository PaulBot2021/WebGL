using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        this.transform.Translate(.3f * Time.deltaTime, 0f, 0.0f);
        Object1.transform.Rotate(0f, 35f * Time.deltaTime, 0f);
        Object2.transform.localScale += new Vector3(0f, 0.05f,0f);
    }
}
