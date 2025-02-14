using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Entity<DerivedType> : MonoBehaviour
where DerivedType : Entity<DerivedType>
{
    private readonly Dictionary<Type, IEntityComponent<DerivedType>> componentDictionary = new();
    protected virtual void Start()
    {
        List<IEntityComponent<DerivedType>> componentList =
            GetComponentsInChildren<IEntityComponent<DerivedType>>(true)
            .ToList();
        componentList.ForEach(x => InitializeEntityComponent(x));
        foreach (IEntityComponentStart<DerivedType> componentStart in componentList.OfType<IEntityComponentStart<DerivedType>>())
            componentStart.EntityComponentStart(this as DerivedType);
    }
    private IEntityComponent<DerivedType> InitializeEntityComponent(IEntityComponent<DerivedType> component)
    {
        componentDictionary.Add(component.GetType(), component);
        if (component is IEntityComponentAwake<DerivedType> instance)
            instance.EntityComponentAwake(this as DerivedType);

        return component;
    }
    public EntityComponentType GetEntityComponent<EntityComponentType>() 
        where EntityComponentType : MonoBehaviour, IEntityComponent<DerivedType>
    {
        if (componentDictionary.TryGetValue(typeof(EntityComponentType), out IEntityComponent<DerivedType> value))
            return value as EntityComponentType;

        Debug.LogError("can't find Entity_Component, reInitializing...", this);

        IEntityComponent<DerivedType> missingInstance = GetComponentInChildren<EntityComponentType>();
        if (missingInstance == null)
        {
            Debug.LogError("can't find it!! again!!!", this);
            return null;
            //missingInstance = gameObject.AddComponent<EntityComponentType>();
        }

        InitializeEntityComponent(missingInstance);
        if (missingInstance is IEntityComponentStart<DerivedType> startInstance)
            startInstance.EntityComponentStart(this as DerivedType);

        return missingInstance as EntityComponentType;
    }

}