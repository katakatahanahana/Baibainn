using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WstermelonScript : MonoBehaviour
{
    public Transform wmtransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        wmtransform = this.transform;
        Vector3 pos = wmtransform.position;
        
    }
}
