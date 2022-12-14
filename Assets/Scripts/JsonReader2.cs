
using System;
using System.IO;
using UnityEngine;


public class JsonReader2  : MonoBehaviour
{

  //  public static JsonReader instance;
    public EmployeeList MyemployeeList = new EmployeeList();



    public void list11(string jsonFile)
    {

        // string [] Text2Parsing = File.ReadAllLines(jsonFile);
        string textTMp = File.ReadAllText(jsonFile);
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(textTMp);
  

    }


    [System.Serializable]
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;

    }

    public class EmployeeList
    {
        public Employee[] employees;

    }
}





