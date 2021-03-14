using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    public Color[] colorbank;
    public int[] colorId = {0, 1, 1, 2, 1, 2, 0, 1};

   
    // Start is called before the first frame update
    void Start()
    {
        Coloring();
    }

    public void Coloring()
    {
        int Id = SpawnerControl.getId();
        if(Id < colorId.Length)
        {
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            SpawnerControl.setColor(s, colorbank[colorId[Id]]);
            SpawnerControl.setId(Id + 1);
            
        }
        else
        {
            SpawnerControl.setId(0);
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            SpawnerControl.setColor(s, colorbank[colorId[0]]);
            SpawnerControl.setId(1);
        }
                  
    }

}
