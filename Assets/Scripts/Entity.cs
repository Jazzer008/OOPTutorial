using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {  // entity also inherits from MonoBehaviour, 
    //which just means it's a component, or something that you can attached to gameObjects in Unity
    // we could remove that and it would just be a pure class on it's own, which we could then use constructors with, and call new Entity()
    //but because it's a MonoBehaviour we have to treat it as a component ie: AddComponent<Entity>(), AddComponent<Dog>(), etc

    // here, functions and variables that should be available to all possible entities exist

    [SerializeField]    //Use this tag to show and 'save' private variables in the inspector
    private int health;     //Serialse means save basically, which means when you stop playing or close unity it will save the value in the editor

    protected bool isOrange = false;

    void Awake(){   //Awake is always called first, before Start
        Init();     //We only have one Awake, and only call Init from here. Init is a virtual function, but awake is not.
        //We can override Init.
        //Init called from here will call the highest level class override.
        //So if we override in WhiteCat, then that Init will be called instead.
    }

    //protected means classes which inherit from entity can see it, but no one else, 
    //private means only that class can see it
    //public means everyone can see it

    //virtual means it can be overridden
    protected virtual void Init(){  

        this.health = 100;  //don't have to use 'this.' necessarily but it can be good pratice, 
        //mostly used for clarify beyween parameters and local variables / functions eg: see SetHealth function
    }

    protected void SetHealth(int health){
        this.health = health;
    }

    public virtual int GetHealth(){
        return health;
    }

}
