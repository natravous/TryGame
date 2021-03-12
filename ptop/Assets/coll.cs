using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("OK");
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("HEY");
    //    Destroy(gameObject);
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    Debug.Log("HEY");
    //    habis();
    //}


    IEnumerator habis()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("HALLO");
        Destroy(gameObject);
    }
}
