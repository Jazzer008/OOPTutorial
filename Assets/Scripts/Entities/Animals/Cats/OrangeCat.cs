using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCat : Cat {   //OrangeCat inherits from Cat

    //here we purposefully hide the Entity.Awake() call, overriding it
    void Awake(){

        //becase of this, the Init function is not called in the Entity.Awake() function
        //so we will call it ourselves here

        Init();

        //even if we use base.Init() instead, it will call the highest overriden function, which for white cat, is Cat.Init()

    }

    //I'm now going to override two 'variables'
    //Or rather, one variable: isOrange and one accessor: color
    //It's an accessor because it uses gets and sets

    protected new bool isOrange = true;

    protected override Color color
    {
        get
        {
            // we just want to do the same as Animal.color here so we'll just return base.color
            return base.color;
        }
        set
        {
            //this is the part we want to change, but we still can use the functionality of setting the sprite renderer color
            //which is in the Animal.color.set function
            //we do want to change the color before it gets there though
            //so we'll just change value

            value = new Color(1.0f, 0.5f, 0.0f);
            base.color = value;
        }

        //so this overrides the color setter
        //so when Init() is called, and subseqently, it inits our color variable to 'white'
        //it will come through here instead and we'll change the value from white to orange
        //and then pass that value through to the base setter where it will set the SpriteRenderer's color
    }
}
