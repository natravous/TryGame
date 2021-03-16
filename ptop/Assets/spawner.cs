using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject obj;
    //private float[] Gap = {1f, 1.2f, 2f, 0.7f, 1f, 1.2f, 2f, 0.7f, 1f, 1.2f, 2f, 0.7f, 1f, 1.2f, 2f, 0.7f, 1f, 
    //    1.2f, 2f, 0.7f, 1f, 1.2f, 2f, 0.7f };
    private float totalTime = 0f;
    private float[] Width = { 10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16 , 
        10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16, 10, 12, 11, 9, 15, 12, 10, 16 };


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< Width.Length; i++) 
        {
            if (i==0)
            {
                StartCoroutine(Repeating(0,0));
                totalTime += CalculateTime(Width[i],0)/2 ;
            }
            else if(i+1< Width.Length)
            {
                StartCoroutine(Repeating(totalTime, i));
                totalTime += CalculateTime(Width[i], Width[i+1]) /2;
            }
            else
            {
                StartCoroutine(Repeating(totalTime, i));
                totalTime += CalculateTime(Width[i], 0) * Time.deltaTime * 60;
            }
            
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
        SpawnerControl.setSize(obj, Width[index], 1);
        Vector2 vct = new Vector2(transform.position.x+(Width[index]/2), 0);
        SpawnerControl.setPosition(obj, vct);
        Instantiate(obj);
    }
    float CalculateTime(float widthA, float widthB)
    {
        float predictTime = (widthA)+(widthB) - (Mathf.Abs(widthA - widthB))/2;

        return predictTime;
    }
}   
