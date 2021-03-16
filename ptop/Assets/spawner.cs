using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private float totalTime = 0f;
    private float[] Width = { 10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16 , 
        10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16 };
    

    // Start is called before the first frame update
    void Start()
    {
        //first block [white]
        StartCoroutine(Repeating(0, -1));

        //block iteration based on the data
        for (int i = 0; i< Width.Length; i++) 
        {
            StartCoroutine(Repeating(totalTime, i));
            totalTime += (Width[i] / SpawnerControl.getRange());
        }
    }
    IEnumerator Repeating(float time, int index)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("This block spawn at " + time.ToString()+"s");
        BlockSpawn(index); 
    }
    void BlockSpawn(int index)
    {
        Vector2 vct;
        switch (index)
        {
            //case -1 only spawn the first white block
            case -1:
                SpawnerControl.setSize(obj, 18, 0.5f);
                vct = new Vector2(transform.position.x - (18 / 2), -4);
                SpawnerControl.setPosition(obj, vct);
                Instantiate(obj);
                break;
            default:
                SpawnerControl.setSize(obj, Width[index], 0.5f); //change value of height
                vct = new Vector2(transform.position.x + (Width[index] / 2), -4);
                SpawnerControl.setPosition(obj, vct);
                Instantiate(obj);
                break;
        }
        
    }

}   
