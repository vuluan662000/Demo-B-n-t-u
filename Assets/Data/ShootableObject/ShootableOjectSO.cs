using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ShootableObject", menuName = "SO/ShootableObject")]
public class ShootableOjectSO : ScriptableObject
{
    // Start is called before the first frame update
    public string objName = "Shootable Object";
    public ObjectType objectType; 
    
    public int hpMax = 2;
    public List<DropRate> dropList;
}
