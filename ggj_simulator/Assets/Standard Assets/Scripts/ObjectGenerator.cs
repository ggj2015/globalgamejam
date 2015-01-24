using UnityEngine;
using System.Collections;

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
    public Transform table;

    public Transform player_type_1;
    public Transform player_type_2;

    private Vector3 tablePosition;
    private Vector3 tableSize;

    private float tableLeftX;
    private float tableTopY;
    private float tableBottomZ;

    private float personSpotXPosInterval;
    
	void Start ()
    {
        tablePosition = table.position;
        tableSize = table.renderer.bounds.size;

        tableLeftX = tablePosition.x - tableSize.x / 2;
        tableTopY = tablePosition.y + tableSize.y / 2;
        tableBottomZ = tablePosition.z - tableSize.z / 2;

        personSpotXPosInterval = (PersonSpotLastXPos - PersonSpotFirstXPos) / (spotsPerRow - 1);

        spawnLaptops();
        spawnChairs();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void spawnLaptops()
    {
        var laptopXPos = PersonSpotFirstXPos;
        var laptopSize = laptop.renderer.bounds.size;

        for (int i = 0; i < spotsPerRow; ++i)
        {
            Instantiate(laptop, new Vector3(tableLeftX + tableSize.x * laptopXPos, tableTopY + laptopSize.y / 2, tableBottomZ + tableSize.z * LaptopZPositionForBottomRow), Quaternion.identity);
            Instantiate(laptop, new Vector3(tableLeftX + tableSize.x * laptopXPos, tableTopY + laptopSize.y / 2, tableBottomZ + tableSize.z * LaptopZPositionForTopRow), Quaternion.identity);
            laptopXPos += personSpotXPosInterval;
        }
    }

    public void spawnChairs()
    {
        var chairXPos = PersonSpotFirstXPos;
        var chairSize = chair.renderer.bounds.size;

        for (int i = 0; i < spotsPerRow; ++i)
        {
            var chairBotPos = new Vector3(tableLeftX + tableSize.x * chairXPos, ChairYPosition + chairSize.y / 2, tableBottomZ + tableSize.z * ChairZPositionForBottomRow);
            var chairTopPos = new Vector3(tableLeftX + tableSize.x * chairXPos, ChairYPosition + chairSize.y / 2, tableBottomZ + tableSize.z * ChairZPositionForTopRow);

            Instantiate(chair, chairBotPos, Quaternion.identity);
            Instantiate(chair, chairTopPos, Quaternion.identity);

            var playerYPosOffsetFromChair = 10.0f;  // hm....
            var playerBotPos = new Vector3(chairBotPos.x, chairBotPos.y + playerYPosOffsetFromChair, chairBotPos.z);
            var playerTopPos = new Vector3(chairTopPos.x, chairTopPos.y + playerYPosOffsetFromChair, chairTopPos.z);

            var playerPreFab = i % 2 == 0 ? player_type_1 : player_type_2;
            Instantiate(playerPreFab, playerBotPos, Quaternion.identity);
            Instantiate(playerPreFab, playerTopPos, Quaternion.identity);

            chairXPos += personSpotXPosInterval;
        }
    }
}
