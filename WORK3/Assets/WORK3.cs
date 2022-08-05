using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WORK3 : MonoBehaviour
{
    string heroname = "Super hero";
    int Heropower = 14;
    string VillainName = "hard Villain";
    int Villainpower = 17;
    float playerSpeed = 6.1f;

    // Start is called before the first frame update
    void Start()
    {
        setspeed(6.3f);

        if (Heropower > Villainpower)
        {
            print(Heropower + "is bager than" + Villainpower);

        }
        else if (Villainpower > Heropower)

        {
            print("Villainpower");


        }


        else
        {
            print("strong");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void setspeed(float newspeed)
    {
        print(playerSpeed);
        playerSpeed = newspeed;
        print(playerSpeed);
    }



}

