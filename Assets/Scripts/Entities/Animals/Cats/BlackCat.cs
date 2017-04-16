using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCat : Cat {   //BlackCat inherits from Cat

    //here we are careful to use Start instead of Awake, or we would have hidden the Entity.Awake() function (overriding it basically)
    void Start(){
        SetColor(Color.black);
        SetHealth(50);  //black cats are unlucky
    }

    //we'll override this virtual function so we can do some extra stuff for the Black cat
    public override int GetHealth()
    {
        //black cats are unlucky so everytime something calls this function we will take some health away too
        // we do this by getting the current health, minusing 1, then setting the health to that result
        this.SetHealth(base.GetHealth() - 1);

        // we will still call the base health, Entity.GetHealth, (which just returns the health count)
        // then we return that returned int straight away
        return base.GetHealth();
    }

}
