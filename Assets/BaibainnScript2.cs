using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaibainnScript2 : MonoBehaviour
{
    public GameObject Object;
    public int count;
    public float countTime;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Object,new Vector3(0.0f, 1.0f, 0.0f),Quaternion.Euler(90, 90, 0));  
        countTime = 0f; 
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
        countTime += Time.deltaTime; 
        // 10秒ごとに生成
        if(countTime >= 10f)
        {
            countTime = 0f;
            count *= 2;
            StartCoroutine("Counter");
        }  
    }
     IEnumerator Counter()
     {
        for (int i=0; i<count-count/2; i++)
        {
            yield return new WaitForSeconds(0.1f);
            //ランダムにしてみる？
            Instantiate(Object,new Vector3(Random.Range(0.0f, 2.0f), 1.0f, Random.Range(0.0f, 2.0f)),Quaternion.Euler(90, 90, 0));
        }
     }
}
