using UnityEngine;
using Entitas;

public class CharModel : IComponent
{
    public GameObject gameObject
    {
        get { return _gameObject; }
        set { _gameObject = value; }
    }
    protected GameObject _gameObject = null;
}
