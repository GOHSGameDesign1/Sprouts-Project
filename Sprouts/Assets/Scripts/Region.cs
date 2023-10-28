using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region
{
    private List<Boundary> boundaries;

    public Region(List<Boundary> boundaries)
    {
        this.boundaries = boundaries;
    }
}
