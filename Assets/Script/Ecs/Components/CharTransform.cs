using UnityEngine;
using Entitas;

public class CharDirtyComponent : IComponent
{
    public bool dirty
    {
        get { return _dirty; }
        set { _dirty = value; }
    }
    protected bool _dirty = false;
}

[Game]
public class CharPosition : CharDirtyComponent
{
    public Vector3 position
    {
        get { return _position; }
        set { _position = value; _dirty = true; }
    }
    Vector3 _position;
}

[Game]
public class CharRotation : CharDirtyComponent
{
    public Quaternion rotation
    {
        get { return _rotation; }
        set { rotation = value; _dirty = true; }
    }
    Quaternion _rotation;
}