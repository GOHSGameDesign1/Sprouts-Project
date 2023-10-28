using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  A position can be cut into 2 lands when those lands have no letter in common. 
 *  The end-of-land character is “]”. 
*/
public class Land 
{
    public List<Region> regions { get; private set; }

    public Land(List<Region> regions) 
    { 
        this.regions = regions;
    }


}
