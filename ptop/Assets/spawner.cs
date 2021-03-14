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
        InvokeRepeating("Repeating", Awal, Antara);
    }
    void Repeating()
    {
        int width = Random.Range(10, 50);
        SpawnerControl.setWidth(obj, width);
        Vector2 vct = new Vector2(transform.position.x, Random.Range(-5, 5));
        SpawnerControl.setPosition(obj, vct);
        Instantiate(obj);
    }

    void Update()
    {
        
        
    }
}
