using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPropertiesControl : MonoBehaviour
{
    public Color[] colorbank;
    private int[] colorId = {-1, 0, 1, 0, 2, 1, 2, 0, 1,0,0,0,1,1,1,2,2,2};

   
    // Start is called before the first frame update
    void Start()
    {
        Coloring();
    }

    public void Coloring()
    {
        int Id = SpawnerControl.getId();
        SpriteRenderer s;
        switch (Id)
        {
            //case 0 only for first white coloring
            case 0:
                s = GetComponent<SpriteRenderer>();
                SpawnerControl.setColor(s, Color.white);
                SpawnerControl.setId(1);
                break;
            default:
                if (Id < colorId.Length)
                {
                    s = GetComponent<SpriteRenderer>();
                    SpawnerControl.setColor(s, colorbank[colorId[Id]]);
                    SpawnerControl.setId(Id + 1);
                }
                else
                {
                    s = GetComponent<SpriteRenderer>();
                    SpawnerControl.setColor(s, colorbank[colorId[1]]);
                    SpawnerControl.setId(2);
                }
                break;
        }            
    }

}
