using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAnim : MonoBehaviour
{
    public Transform oscOBj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscOBj.position.x * 0.1f;
        transform.position = new Vector3(0, adsr, 0);
    }
}
