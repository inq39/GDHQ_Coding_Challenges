using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;

    public Customer(string firstName, string lastName, int age, string gender)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    }
}
