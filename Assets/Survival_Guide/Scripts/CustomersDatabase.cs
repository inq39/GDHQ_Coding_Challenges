using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomersDatabase : MonoBehaviour
{
    [SerializeField]
    private Customer _customer1;
    [SerializeField]
    private Customer _customer2;
    [SerializeField]
    private Customer _customer3;

    [SerializeField]
    private Customer[] _customers;
    // Start is called before the first frame update
    void Start()
    {
        _customer1 = new Customer("Jens", "Heinrich", 20, "male");
        _customer2 = new Customer("Steven", "Malschik", 23, "male");
        _customer3 = new Customer("Britney", "Spears", 39, "female");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
