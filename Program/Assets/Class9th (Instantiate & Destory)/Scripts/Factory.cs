using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    SLIME,
    WRAITH
}

public class Factory : MonoBehaviour
{
    public Slime slime;
    public Wraith wraith;

    public void Create(UnitType unitType)
    {
        Unit unit = null;

        float x = Random.Range(0.0f, 5.0f); // 0 이상 5 미만
        float z = Random.Range(0.0f, 5.0f);

        switch(unitType)
        {
            case UnitType.SLIME: unit = Instantiate(slime, new Vector3(x, 0, z), Quaternion.identity); // Quaternion : 회전 값
                break;

            case UnitType.WRAITH: unit = Instantiate(wraith, new Vector3(x, 0, z), Quaternion.identity);
                break;

            default:
                break;
        }

        unit.Move();
    }
}