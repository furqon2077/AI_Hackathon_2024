using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainData : MonoBehaviour
{
    [SerializeField] TMP_InputField firstName;
    [SerializeField] TMP_InputField lastName;
    public string firstNameValue;
    public string lastNameValue;


    public void EnterExam()
    {
        firstNameValue = firstName.text;
        lastNameValue = lastName.text;
        Debug.Log("First Name: " + firstNameValue + " Last Name: " + lastNameValue);
    }

}
