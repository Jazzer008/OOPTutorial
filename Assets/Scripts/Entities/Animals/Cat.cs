using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal { //Cat inherits from Animal

    protected override void Init()
    {
        // if we want to, we don't have to call the base Init when we override

        //base.Init(); 

        // but this means that Animal and Entity Init won't be called
        // so our health is null (which means it's 0) and our color is null (which just means it's Color.black, sometimes Color.white)
        // if they were classes or pointers they would be properly NULL
        // but because it's a int and a struct (Color) they just set to their default values, 0 & Color.black
        // a struct is just a container for variables, think of it like a Vector, which has 3 variables and some functions you can call
        // but it is not a class

        // anyway, becasue health is 0 we should probably set that
        // we can't access the 'health' variable in 'Entity' because it is private, but the SetHealth function is protected so we can call that
        this.SetHealth(100);    //again, don't necessarily need the 'this.' but it's safer and gives clarity in my opinion

        // we can access the color variable because it is only protected and not private, so we'll just set that directly
        this.color = Color.cyan;

        // of course we can access the SetColor function too, I've not used 'this.' just to demostrate it will call the same function
        // if there was another function somewhere, perhaps static, that was the same, then we would need the 'this.' to clarify which one we wanted to call
        SetColor(Color.white);
    }
}
