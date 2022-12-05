using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int level;
    public int exp;
    [Tooltip("Experiencia necesaria para pasar de un nivel a otro")]
    public int[] expToLevelUp;


    public void AddExperience(int expToAdd)
    {
        exp += expToAdd;
        if (level >= expToLevelUp.Length) 
        {
            return; 
        }
        if (exp >= expToLevelUp[level])
        {
            level++;
            exp -= expToLevelUp[level - 1];
        }
    }
}
