using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public struct PositionData
{
    public List<List<List<List<Spot>>>> StructuredRep; // List of lands > list of regions > list of boundaries > list of spots
    public string StringRep; 
}

public class SproutsManager : MonoBehaviour
{

    const char END_LAND = ']';
    const char END_REGION = '}';
    const char END_BOUNDARY = '.';
    const char END_POSITION = '!';
    char[] SPOT_CHARS = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    List<Land> _lands = new List<Land>();
    List<Spot> _spots = new List<Spot>();
    string stringRep; 
    // Start is called before the first frame update
    void Start()
    {
        CreateEmptyPosition(3);
        Debug.Log("Lands: " + _lands.Count() + ".  Regions: " + _lands[0].regions.Count() + ".  Boundaries: " + _lands[0].regions[0].boundaries.Count());
        Debug.Log("\n" + StringFromStructured());
    }

    public void CreateEmptyPosition(int numSpots)
    {
        List<Region> regions = new List<Region>();
        List<Boundary> boundaries = new List<Boundary>();
        for(int i = 0; i < numSpots; i++)
        {
            Spot tempSpot = new Spot(SPOT_CHARS[i]);
            // tempSpot.stringChar = '0';
            List<Spot> tempSpotList = new List<Spot>() { tempSpot };
            _spots.Add(tempSpot);

            boundaries.Add(new Boundary(tempSpotList));
        }
        regions.Add(new Region(boundaries));

        _lands.Add(new Land(regions));
    }

    // Returns string from structured position
    private string StringFromStructured()
    {
        string result = null;

        foreach (Land land in _lands)
        {
            List<Region> regions = land.regions;
            foreach (Region region in regions)
            {
                List<Boundary> boundaries = region.boundaries;
                foreach(Boundary boundary in boundaries)
                {
                    List<Spot> spots = boundary.spots;
                    foreach(Spot spot in spots)
                    {
                        result += spot.stringChar; // Input the character assigned to each spot
                    }

                    result += END_BOUNDARY; // Add End Boundary character after adding that boundary's spots
                }

                result += END_REGION; // Add End Region character after adding that region's boundaries and spots
            }
            result += END_LAND; // Add End Land character after adding that land's regions, boundaries, and spots
        }

        return result;
    }
}
