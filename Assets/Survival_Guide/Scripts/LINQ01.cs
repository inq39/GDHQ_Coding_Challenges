using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQ01 : MonoBehaviour
{
    [SerializeField]
    private int[] _grades =  {13, 23, 39, 93};
    // Start is called before the first frame update
    void Start()
    {
        var newGrades = _grades.Where(qg => qg > 35);
        
        foreach (var grade in newGrades)
        {
            Debug.Log("Grades good: " + grade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
