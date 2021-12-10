using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    // can't see 2D array in inspector
    public Transform[] roomSpawnersRow0;
    public Transform[] roomSpawnersRow1;
    public Transform[] roomSpawnersRow2;
    public Transform[] roomSpawnersRow3;
    public Transform[] roomSpawnersRow4;
    public Transform[] roomSpawnersRow5;

    public GameObject[] rooms;

    public int testRow = 0;
    public int testColumn = 0;
    public int testType = 0;

    bool[,] array = {
                    { false, false, false, false, false, false}, 
                    { false, false, false, false, false, false}, //1 or 2
                    { false, false, false, false, false, false}, //2 or 4
                    { false, false, false, false, false, false}, //2 or 4
                    { false, false, false, false, false, false}, //1 or 3
                    { false, false, false, false, false, false}
                   };

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddRoom(testRow, testColumn, testType);
        }
	}


    public void AddRoom(int row, int column, int roomType)
    {
        Vector3 spawnPos = Vector3.zero;

        for(int j = 0; j <= 5; j++)
        {
            column = j;

            spawnPos = roomSpawnersRow0[column].position;
            Instantiate(rooms[0], spawnPos, transform.rotation);

            spawnPos = roomSpawnersRow5[column].position;
            Instantiate(rooms[0], spawnPos, transform.rotation);
        }

        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j <= 5; j++)
            {
                row = i;

                column = j;

                if (row == 1)
                {
                    spawnPos = roomSpawnersRow1[column].position;

                    if(column == 1 || column == 4)
                    {
                        int[] random = new int[] {0, 1, 2, 4};
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }

                    else
                    {
                        int[] random = new int[] { 1, 2, 3, 4 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }
                }

                if(row == 2 )
                {
                    spawnPos = roomSpawnersRow2[column].position;

                    if (column == 0 || column == 3)
                    {
                        int[] random = new int[] { 0, 2, 4 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }

                    else
                    {
                        int[] random = new int[] { 1, 2, 3, 4 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }
                }

                if (row == 3)
                {
                    spawnPos = roomSpawnersRow3[column].position;

                    if (column == 0 || column == 3)
                    {
                        int[] random = new int[] { 0, 2, 4 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }

                    else
                    {
                        int[] random = new int[] {1, 2, 3, 4 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }
                }

                if (row == 4)
                {
                    spawnPos = roomSpawnersRow4[column].position;

                    if (column == 0 || column == 3)
                    {
                        int[] random = new int[] { 0, 1, 3 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }

                    else
                    {
                        int[] random = new int[] { 1, 3 };
                        roomType = (random[Random.Range(0, random.Length)]);
                        Instantiate(rooms[roomType], spawnPos, transform.rotation);
                    }
                }
            }
        }

        //Vector3 spawnPos = Vector3.zero;

        // figure out position to spawn at

        /*switch (row)
        {
            case 0:
                spawnPos = roomSpawnersRow0[column].position;
                break;
            case 1:
                spawnPos = roomSpawnersRow1[column].position;
                break;
            case 2:
                spawnPos = roomSpawnersRow2[column].position;
                break;
            case 3:
                spawnPos = roomSpawnersRow3[column].position;
                break;
        }*/

        // actually spawn it
        //Instantiate(rooms[roomType], spawnPos, transform.rotation);
    }


}
