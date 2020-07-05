using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    
    public int xLength = 16, yLength = 16;
    public GameObject tile;
    public Sprite[] Characters = new Sprite[7];
    public GameObject[,] tiles;
    // Start is called before the first frame update
    void Start()
    {
        
        Vector2 offset = tile.GetComponent<SpriteRenderer>().bounds.size;
        CreateBoard(offset.x,offset.y);

    }

    void CreateBoard(float xOffset, float yOffset)
    {
        tiles = new GameObject[xLength,yLength]; 

        float startX = transform.position.x;
        float startY = transform.position.y;

        for(int i = 0; i < xLength; i++)
        {
            for(int j = 0; j < yLength; j++)
            {
                GameObject cloneTile =  Instantiate(tile, new Vector3(startX+(xOffset * i),startY+(yOffset * j),0),tile.transform.rotation);
                tiles[i,j] = cloneTile;
            }
            
        }
    }
}
