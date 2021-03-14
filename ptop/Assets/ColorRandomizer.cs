using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    public Color[] colorbank;
    public bool sprite;

    // Start is called before the first frame update
    void Start()
    {
        ColorRandom();
    }

    public void ColorRandom()
    {
            int Num = Random.Range(0, colorbank.Length);
            if (sprite)
            {
                SpriteRenderer s = GetComponent<SpriteRenderer>();
                s.color = colorbank[Num];
            } Delay();
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(10f);
    }
}
