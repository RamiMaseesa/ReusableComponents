using UnityEngine;

public class OddsComp : MonoBehaviour
{

    /// <summary>
    /// the will check 1 in chance
    /// </summary>
    /// <param name="chance"></param>
    public bool CheckOneIn(float odds) {
        return Random.value < (1f / odds);
    }
}
