using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public List<Spot> spots { get; private set; }

    public Boundary(List<Spot> spots)
    {
        this.spots = spots;
    }
}
