using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Node : IHeapItem<Node>
{
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;

    public int gcost;
    public int hcost;

    public Node parent;

    int heapIndex;

    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPosition = _worldPos; 
        gridX = _gridX;
        gridY = _gridY;
    }

    public int fcost
    {
        get { return gcost + hcost; }
    }

    public int HeapIndex
    {
        get { return heapIndex; }
        set { heapIndex = value; }
    }

    public int CompareTo(Node nodeToCompare)
    {
        int compare = fcost.CompareTo(nodeToCompare.fcost);
        if(compare == 0) { 
            compare = hcost.CompareTo(nodeToCompare.hcost);
        }
        return -compare;
    }
}
