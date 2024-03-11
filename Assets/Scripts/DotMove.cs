using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMove : MonoBehaviour
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
        float adsr = oscObj.position.x * 0.1f;
        mat.SetVector("_Pos", new Vector2(adsr, 1 - adsr));
    }
}
