using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Instantiate_Position;
    public GameObject Box;
    public GameObject[] array;
    public int count = 0;
    public float times = 0f;
    public List<Transform> grounds;
    void Start()
    {
        grounds = new List<Transform>();
        InvokeRepeating("Spawn", 0.0F, 10.0F);
    }
    public void Spawn()
    {
        GameObject newwall = Instantiate(Box);
        newwall.transform.position = new Vector3(1, 5, -8);
        grounds.Add(newwall.transform);
        count++;
    }
    public void controlspawn()
    {
        if (count > 1)
        {
            DestroyImmediate(grounds[0].gameObject, true);
            //estroy(grounds[0].gameObject);
            grounds.RemoveAt(0);
            count--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        controlspawn();
    }
}
