using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectGenerator : MonoBehaviour
{
    public const float PersonSpotFirstXPos = 0.10f;
    public const float PersonSpotLastXPos = 0.90f;

    public const float LaptopZPositionForBottomRow = 0.20f;
    public const float LaptopZPositionForTopRow = 0.80f;

    public const float ChairZPositionForBottomRow = -0.40f;
    public const float ChairZPositionForTopRow = 1.0f - ChairZPositionForBottomRow;
    public const float ChairYPosition = 0.0f;

    public int spotsPerRow;

    public Transform laptop;
    public Transform chair;

    public Transform table0;
    public Transform table1;
    public Transform table2;
    public Transform table3;
    public Transform table4;
    public Transform table5;

    public IList<Transform> tables;

    public Transform player_type_1;
    public Transform player_type_2;
    public Transform player_type_3;

    private IList<Vector3> tablePositions;
    private IList<Vector3> tableSizes;

    private IList<float> tableLeftXs;
    private IList<float> tableTopYs;
    private IList<float> tableBottomZs;

    private float personSpotXPosInterval;
    
	void Start ()
    {
        tables = new List<Transform>();

        tablePositions = new List<Vector3>();
        tableSizes = new List<Vector3>();

        tableLeftXs = new List<float>();
        tableTopYs = new List<float>();
        tableBottomZs = new List<float>();

        tables.Add(table0);
        tables.Add(table1);
        tables.Add(table2);
        tables.Add(table3);
        tables.Add(table4);
        tables.Add(table5);

        for (int i = 0; i < tables.Count; ++i)
        {
            tablePositions.Add(tables[i].position);
            tableSizes.Add(tables[i].renderer.bounds.size);

            tableLeftXs.Add(tablePositions[i].x - tableSizes[i].x / 2);
            tableTopYs.Add(tablePositions[i].y + tableSizes[i].y / 2);
            tableBottomZs.Add(tablePositions[i].z - tableSizes[i].z / 2);
        }

        personSpotXPosInterval = (PersonSpotLastXPos - PersonSpotFirstXPos) / (spotsPerRow - 1);

        for (int i = 0; i < tables.Count; ++i)
        {
            spawnLaptops(i);
            spawnChairs(i);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void spawnLaptops(int tableIndex)
    {
        var laptopXPos = PersonSpotFirstXPos;
        var laptopSize = laptop.renderer.bounds.size;

        for (int i = 0; i < spotsPerRow; ++i)
        {
            var laptopXPosAbsolute = tableLeftXs[tableIndex] + tableSizes[tableIndex].x * laptopXPos;
            var laptopYPosAbsolute = tableTopYs[tableIndex] + laptopSize.y / 2;
            Instantiate(laptop, new Vector3(laptopXPosAbsolute, laptopYPosAbsolute, tableBottomZs[tableIndex] + tableSizes[tableIndex].z * LaptopZPositionForBottomRow), Quaternion.identity);
            Instantiate(laptop, new Vector3(laptopXPosAbsolute, laptopYPosAbsolute, tableBottomZs[tableIndex] + tableSizes[tableIndex].z * LaptopZPositionForTopRow), Quaternion.Euler(0, 180, 0));
            laptopXPos += personSpotXPosInterval;
        }
    }

    public void spawnChairs(int tableIndex)
    {
        var chairXPos = PersonSpotFirstXPos;
        var chairSize = chair.renderer.bounds.size;

        for (int i = 0; i < spotsPerRow; ++i)
        {
            var chairXPosAbsolute = tableLeftXs[tableIndex] + tableSizes[tableIndex].x * chairXPos;
            var chairYPosAbsolute = ChairYPosition + chairSize.y / 2;
            var chairBotPos = new Vector3(chairXPosAbsolute, chairYPosAbsolute, tableBottomZs[tableIndex] + tableSizes[tableIndex].z * ChairZPositionForBottomRow);
            var chairTopPos = new Vector3(chairXPosAbsolute, chairYPosAbsolute, tableBottomZs[tableIndex] + tableSizes[tableIndex].z * ChairZPositionForTopRow);

            Instantiate(chair, chairBotPos, Quaternion.Euler(270, 0, 0));
            Instantiate(chair, chairTopPos, Quaternion.Euler(270, 180, 0));

            var playerYPosOffsetFromChair = 10.0f;  // hm....
            var playerBotPos = new Vector3(chairBotPos.x, chairBotPos.y + playerYPosOffsetFromChair, chairBotPos.z);
            var playerTopPos = new Vector3(chairTopPos.x, chairTopPos.y + playerYPosOffsetFromChair, chairTopPos.z);

            var playerPreFab = i % 2 == 0 ? (player_type_1) : (i % 3 == 0 ? player_type_2 : player_type_3);
            Instantiate(playerPreFab, playerBotPos, Quaternion.identity);
            Instantiate(playerPreFab, playerTopPos, Quaternion.identity);

            chairXPos += personSpotXPosInterval;
        }
    }
}
