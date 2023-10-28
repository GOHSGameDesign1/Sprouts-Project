using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  A position can be cut into 2 lands when those lands have no letter in common. 
 *  The end-of-land character is “]”. 
*/
public class Land 
{
    private List<Region> regions;

    public Land(List<Region> regions) 
    { 
        this.regions = regions;
    }
}
