using Class;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private List<UIManagedClass> uiObjects = new List<UIManagedClass>();

    public static UIManager instance { get; private set; }

    private void Awake()
    {
        
        instance = this;

    }

    public T GetUIObject<T>(string name)
    {

        var obj = uiObjects.Find(x => x.key == name);
        return obj.uiObject.GetComponent<T>();

    }

}
