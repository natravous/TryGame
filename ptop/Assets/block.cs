using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    //public Vector2 velco = new Vector2(-5, 0);
    
    public float range;
    public float waktu;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //hancur();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - range * Time.deltaTime, transform.position.y, transform.position.z);
        StartCoroutine(hancur());
    }

    

    IEnumerator hancur()
    {
        yield return new WaitForSeconds(waktu);
        Destroy(gameObject);
    }

}
