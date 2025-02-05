using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaibainnScript2 : MonoBehaviour
{
    public GameObject wm;
    public int count;

    public float countTime;
    // Start is called before the first frame update
    void Start()
    { 
        countTime = 0f; 
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime; 
        // 5秒ごとに生成
        if(countTime >= 5f)
        {
            countTime = 0f;
            count *= 2;
            StartCoroutine("Counter");
        }  
    }
     IEnumerator Counter()
     {
        yield return new WaitForSeconds(0.1f);
        Instantiate(this.gameObject,this.transform.position,Quaternion.Euler(90, 90, 0));
     }
}
