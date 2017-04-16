using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Entity {  //Animal inherits from Entity

    protected virtual Color color { 
        get { return this.gameObject.GetComponent<SpriteRenderer>().color; } 
        set { this.gameObject.GetComponent<SpriteRenderer>().color = value; }
    }

    protected override void Init()
    {
        base.Init();    //base means the class below us, or the one we have inherited from ie: Entity
        //this means that although we are override the Init function we can still call the original

        //this also means that we can set the intial health (down in entity)
        //and the initial color, here in animal
        // we can't access these variables and functions from base classes
        //ie: Entity can not see the variable color, even if it was public, but everything above and including animal, can
        //because it is 'protected' not private
        this.color = Color.white;

    }

    protected void SetColor(Color color){
        this.color = color;
    }
}
