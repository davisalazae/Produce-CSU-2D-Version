using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProduceCSU
{
    public class Training : Character
    {
        public float dancingSkill;
        public float singingSkill;
        public float modelingSkill;

        public Training()
        {
            dancingSkill = 0.0f;
            singingSkill = 0.0f;
            modelingSkill = 0.0f;
            GroupLevel = 0.0f;
            Energy = 10;
        }

        public void IndividualTraining(string name)
        {
            GameObject debutpanel = new GameObject("Results are in!");
            debutpanel.transform.SetParent(this.transform);
            Text message = debutpanel.AddComponent<Text>();

            DanceSkill += 1.5f;
            SingingSkill += 1.5f;
            ModelingSkill += 1.5f;
            GroupLevel += 1.0f;
            Energy -= 1;
            while(Energy <= 1)
            {
                print("Energy is too low to practice");
            }
            message.text ="You trained individually. Here are your stats:\n";
            print("Dance Skill: " + DanceSkill);
            print("\nSinging Skill:  " + SingingSkill);
            print("\nModeling Skill: " + ModelingSkill);
            print("\nGroup Level: " + GroupLevel);
            print("\nEnergy: " + Energy);

        }

        public void GroupTraining(string name)
        {
            DanceSkill += 1.0f;
            SingingSkill += 1.0f;
            ModelingSkill += 1.0f;
            GroupLevel += 1.5f;
            Energy -= 2;
            while(Energy <= 1)
            {
                print("Energy is too low to practice");
            }

            print("You trained individually. Here are your stats:\n");
            print("Dance Skill: " + DanceSkill);
            print("\nSinging Skill:  " + SingingSkill);
            print("\nModeling Skill: " + ModelingSkill);
            print("\nGroup Level: " + GroupLevel);
            print("\nEnergy: " + Energy);

        }

      

    }

    
}
