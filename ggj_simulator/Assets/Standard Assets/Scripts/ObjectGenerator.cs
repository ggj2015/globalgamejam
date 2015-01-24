using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour
{
    public const float LaptopFirstXPos = 0.10f;
    public const float LaptopLastXPos = 0.90f;
    public const float LaptopZPositionForBottomRow = 0.20f;
    public const float LaptopZPositionForTopRow = 0.80f;

    public int laptopsPerRow;

    public Transform laptop;
    public Transform table;
    
	void Start ()
    {
        var tablePosition = table.position;
        var tableSize = table.renderer.bounds.size;

        var tableLeftX = tablePosition.x - tableSize.x / 2;
        var tableTopY = tablePosition.y + tableSize.y / 2;
        var tableBottomZ = tablePosition.z - tableSize.z / 2;

        var laptopXPosInterval = (LaptopLastXPos - LaptopFirstXPos) / (laptopsPerRow - 1);
        var laptopXPos = LaptopFirstXPos;

        for (int i = 0; i < laptopsPerRow; ++i)
        {
            Instantiate(laptop, new Vector3(tableLeftX + tableSize.x * laptopXPos, tableTopY, tableBottomZ + tableSize.z * LaptopZPositionForBottomRow), Quaternion.identity);
            Instantiate(laptop, new Vector3(tableLeftX + tableSize.x * laptopXPos, tableTopY, tableBottomZ + tableSize.z * LaptopZPositionForTopRow), Quaternion.identity);
            laptopXPos += laptopXPosInterval;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
