using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Color : MonoBehaviour
{

    private Renderer _sphereMR;
    // Start is called before the first frame update
    void Start()
    {
        _sphereMR = GetComponent<Renderer>();
        StartCoroutine("ShortWait");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShortWait()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            ChangeColor();
        }
        
    }

    private void ChangeColor()
    {
        
        _sphereMR.material.color = new Color(Random.value, Random.value, Random.value);
        
    }
}
