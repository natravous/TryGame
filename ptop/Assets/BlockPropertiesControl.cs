using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPropertiesControl : MonoBehaviour
{
    public Color[] colorbank;
    private int[] colorId = {0, 1, 0, 2, 1, 2, 0, 1,0,0,0,1,1,1,2,2,2};

   
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
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            SpawnerControl.setColor(s, colorbank[colorId[0]]);
            SpawnerControl.setId(1);
        }
                  
    }

}
