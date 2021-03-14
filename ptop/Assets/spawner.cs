using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obj;
    public float Awal = 0f;
    public float Antara = 0f;

    // Start is called before the first frame update
    void Start()
    {
        obj.transform.localScale = new Vector2(10, 10);

        InvokeRepeating("Repeating", Awal, Antara);
    }
    void Repeating()
    {
        Instantiate(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
