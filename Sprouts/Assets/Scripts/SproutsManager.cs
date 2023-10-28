using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SproutsManager : MonoBehaviour
{
    List<Land> _lands = new List<Land>();
    // Start is called before the first frame update
    void Start()
    {
        CreateEmptyPosition(3);
        Debug.Log("Lands: " + _lands.Count() + ".  Regions: " + _lands[0].regions.Count() + ".  Boundaries: " + _lands[0].regions[0].boundaries.Count());
    }

    public void CreateEmptyPosition(int numSpots)
    {
        List<Region> regions = new List<Region>();
        List<Boundary> boundaries = new List<Boundary>();
        for(int i = 0; i < numSpots; i++)
        {
            List<Spot> tempSpotList = new List<Spot>() { new Spot() };
            boundaries.Add(new Boundary(tempSpotList));
        }
        regions.Add(new Region(boundaries));

        _lands.Add(new Land(regions));
    }
}
