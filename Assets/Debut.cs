using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProduceCSU
{
    public class Debut : Training
    {
        // Start is called before the first frame update
        public void debutStatus()
        {
                GameObject debutpanel = new GameObject("Results are in!");
                debutpanel.transform.SetParent(this.transform);
                 Text message = debutpanel.AddComponent<Text>();

                //if the skill levels are 7+, the debut is successful
                if (DanceSkill >= 7f && SingingSkill >= 7f && ModelingSkill >= 7f && GroupLevel >= 7f)
                {
                message.color = Color.green;
                    message.text = "Congratulations! Your group blew away the Ceo and he can't wait to make money- I mean see your group prosper.";
                print(message);
                message.text = "\n Be prepared to hear a sea of fans scream your name. Your hardwork won't go unnoticed.";
                print(message);

                }
                //if the skill is greater than or equal to 4 but less than 6, then they will disband shortly after debuting
                else if (DanceSkill == 5f && SingingSkill == 5f && ModelingSkill == 5f && GroupLevel == 5f)
                {
                    message.color = Color.green;
                    message.text = "Congratulations! Although your stage performance wasn't the best, your group was able to debut!";
                print(message);
                    message.color = Color.yellow;
                    message.text ="\nUnfortunately, your group disbanded a couple of months after you released your first single. Back to training.";
                print(message);
            }

                //else they fail
                else
                {
                    message.color = Color.red;

                    message.text= "I don't know whether it was the lack of harmonization or how unsynchronized your group was but, the ceo was not impressed.. ";
                print(message);
                    message.text= "Maybe dedicate more time into training next time";
                print(message);
                }

            }
 

        // Update is called once per frame
        void Update()
        {

        }
    }
}
