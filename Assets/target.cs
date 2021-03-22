using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision aaa)
    {
        if (aaa.gameObject.tag == "target")
        {
            GameObject.Find("計分").GetComponent<addscore>().addpoint();
            Destroy(this.gameObject);
            Destroy(aaa.gameObject);
        }
    }
}
