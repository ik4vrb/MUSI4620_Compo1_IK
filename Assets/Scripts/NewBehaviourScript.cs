using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform oscObj;
    float accum;
    [Range (0,0.01f)]
    [SerializeField] float accumSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscObj.position.x;
        accum += adsr * accumSpeed;
        transform.position = new Vector3(Mathf.Cos(accum), 0, Mathf.Sin(accum));
    }
}
