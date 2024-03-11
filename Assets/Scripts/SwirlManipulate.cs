using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwirlManipulate : MonoBehaviour
{
    Material mat;
    public Transform oscObj;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float lfo = oscObj.position.x * 100.0f;
        mat.SetFloat("_swirl", lfo);
    }
}
