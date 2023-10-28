using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region
{
    public List<Boundary> boundaries {  get; private set; }

    public Region(List<Boundary> boundaries)
    {
        this.boundaries = boundaries;
    }
}
