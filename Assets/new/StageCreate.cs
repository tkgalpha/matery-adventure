using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreate : MonoBehaviour {

    public GameObject[] a = new GameObject[32];
    
    public Texture2D[] stager;
    private string[] f0 = new string[8];
    
    private string[] Data = new string[5];
    private int f;
    public string kekka;
    public float ox ;
    public float oy ;
    private int ii2;
    int nu = 32;

    public Texture2D __1;
    public Quaternion[] Rota = new Quaternion[32];

    public Texture2D[] tc = new Texture2D[32];
    Color[] oc = new Color[32];
    public Texture2D aaa;
   int zi;

    public int layernumber;

    void Stager()
    {
        float tox = 512f / 12.0f / 2.0f;
        float toy = 512f / 12.0f / 2.0f;
        float ox;
        float oy;

        Rota[2] =Quaternion.Euler(270, 0, 90);
        Rota[3]= Quaternion.Euler(270, 0, 0);

        int sss= 1;

        Color c1;

        for (int shu = 0; shu < 32; shu++)
        {
            if (tc[shu] == null)
            {
                tc[shu] = tc[0];
            }
            if(a[shu] == null)
            {
                a[shu] = a[0];
            }
            oc[shu] = tc[shu].GetPixel(250, 250);
        }

        

        for (int i = 0; i < 144; i++)
        {
            ox = (i % 12) * tox *2.0f;
            oy = Mathf.Floor(i / 12) * toy *2.0f;

            float x = i % 12.0f;
            float y = Mathf.Floor(i / 12.0f);

            c1 = stager[zi].GetPixel(Mathf.FloorToInt(ox + tox), Mathf.FloorToInt(oy + toy));

            float ra = 0.05f;

            for (int ii = 1; ii < 4; ii++)
            {
                if (oc[ii].r>=c1.r-ra && oc[ii].r<=c1.r+ra)
                {
                    if (oc[ii].g >= c1.g - ra && oc[ii].g <= c1.g + ra)
                    {
                        if (oc[ii].b >= c1.b - ra && oc[ii].b <= c1.b + ra)
                        {
                            Instantiate(a[ii], new Vector3(x, zi, y),Rota[ii]);
                        }
                    }
                }
            }

        }

    }



    void paast()
    {
        f0[0] = "a";
        f0[1] = "b";

        for (int ii2 = 0; ii2 < 5; ii2++)
        {
            for (int i = 0; i < 144; i++)
            {





                kekka = Data[ii2].Substring(i, 1);
                for (int i2 = 0; i2 < 8; i2++)
                {

                    if (kekka == f0[i2])
                    {
                        f = i2;

                    }


                }
                float x = i % 12 + ox;
                float y = Mathf.Floor(i / 12) + oy;
                Instantiate(a[f], new Vector3(x, 1 + ii2, y), Quaternion.identity);
            }
        }
    }




    // Use this for initialization
    void Start () {
        Debug.Log("aaaa");
        for (zi=0;zi<=layernumber-1;zi++)
        {
            Stager();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    



}
