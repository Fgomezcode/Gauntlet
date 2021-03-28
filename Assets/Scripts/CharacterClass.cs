using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterClass : MonoBehaviour
{
    // only script to reference the original class; modify the stats in scriptable object.


   [Header("Holds Scriptable Object, Used To Pass Info to Player Spawn")]
   public CharacterObject charStats;
}
