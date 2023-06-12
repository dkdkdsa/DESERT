using Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    [SerializeField] private List<ObjectManageClass> manageClasses = new List<ObjectManageClass>();

    public static ObjectManager instance;

    private void Awake()
    {
        
        instance = this;

    }

    public void EnableObject(string key)
    {

        var obj = manageClasses.Find(x => x.key == key);

        foreach (var item in obj.managedObjects)
        {

            item.EnableObject();

        }
            
    }

}
