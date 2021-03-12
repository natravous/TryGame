using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject[] obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Repeating", .5f, 1.5f);
    }

    void Repeating()
    {
        int Rand = Random.Range(0, obj.Length);
        Instantiate(obj[Rand]);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
