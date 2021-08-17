using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character : MonoBehaviour
{
    public InputField userName;
    public InputField main;
    public InputField userAge;
    public static string username;
    public static int userage;
    public Dropdown roleSelect;
    public static string userrole;

   /* public Character()
    { 
        Energy = 10;
        DanceSkill= 0f;
        SingingSkill = 0f;
        ModelingSkill = 0f;
        GroupLevel = 0f;

    } */
    public InputField UserName(InputField name)
    {
        name = userName;
        name.text.ToString();
        return name;
    }
    public InputField UserAge(InputField age)
    {
        age = userAge;
        age.text.ToString();
        return age;
    }
    private float danceSkill;
   public float DanceSkill
    {
        get
        {
            return danceSkill;
        }
        set
        {
            danceSkill = value;
        }
    }
    private float singingSkill;
    public float SingingSkill
    {
        get
        {
            return singingSkill;
        }
        set
        {
            singingSkill = value;
        }
    }
    private float modelingSkill;
    public float ModelingSkill
    {
        get
        {
            return modelingSkill;
        }
        set
        {
            modelingSkill = value;
        }
    }
    private float groupLevel;
    public float GroupLevel
    {
        get
        {
            return groupLevel;
        }
        set
        {
            groupLevel = value;
        }
    }

    public int Energy { get; set; }
    // Start is called before the first frame update
    private void CharacterSetUp()
    {
        //this.name = userName.text.ToString();
        //userAge = userage;
        Energy = 10;
        DanceSkill = 0f;
        SingingSkill = 0f;
        ModelingSkill = 0f;
        GroupLevel = 0f;

        userName.onValueChanged.AddListener(delegate { DebugInput(); });
        userAge.onValueChanged.AddListener(delegate { DebugInput(); });
    }
    private void DebugInput()
    {
        Debug.Log("Input: " + userName);
    }

    /*int roleNum = GameObject.Find("Singer").GetComponent<Dropdown>().value;        
   switch (roleNum)
   {
       case 0:
           singingSkill += 1.5f;
           break;
       case 1:
           danceSkill += 1.5f;

       break;
       case 2:
           modelingSkill += 1.5f;
           break;
       default:
           break;
   } */




    

    // Update is called once per frame
    void Update()
    {
       
    }
}
