using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal { //Dog inherits from Animal

    protected override void Init()
    {
        base.Init();    // we still want to set the default color and healths so we'll call the base (Animal) Init function

        //dogs are bigger than cats so we will set it's scale to 2 here in Init
        this.transform.localScale = Vector2.one * 2.0f;
    }
}
