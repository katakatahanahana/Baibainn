using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaibainnScript : MonoBehaviour
{
    public GameObject Object;
    public int count;
    public int i;
    public float countTime;
    // Start is called before the first frame update
    void Start()
    {
        countTime = 0f;
        count = 1;
        Instantiate(Object,new Vector3(0.0f, 1.0f, 0.0f),Quaternion.Euler(90, 90, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("i:"+i+"count"+count);
        countTime += Time.deltaTime; 

        for(i = 1;i <= count; i++)
        {
            // Instantiate(Object,Object.transform.position,Quaternion.Euler(90, 90, 0));
        }

        if(countTime >= 5f)
        {
            count *= 2;
            countTime = 0f;
        }
    }
}
