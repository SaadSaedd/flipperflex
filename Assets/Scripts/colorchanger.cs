using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
     
{
    [SerializeField] MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {

        meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    public void Changecolor()
    {

        meshRenderer.material.color = Random.ColorHSV();
    }
}
