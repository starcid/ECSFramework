using UnityEngine;
using Entitas;
using System.Collections.Generic;

public class CharTransformViewSystem : ReactiveSystem<GameEntity>
{
    public CharTransformViewSystem(Contexts contexts) : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf( GameMatcher.CharPosition, GameMatcher.CharRotation ));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasCharDirty && entity.charDirty.dirty;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        for (int i = 0; i < entities.Count; i++)
        {
            if (entities[i].hasCharModel && entities[i].charModel.gameObject != null)
            {
                if (entities[i].charPosition.dirty)
                {
                    entities[i].charModel.gameObject.transform.position = entities[i].charPosition.position;
                    entities[i].charPosition.dirty = false;
                }
                if (entities[i].charRotation.dirty)
                {
                    entities[i].charModel.gameObject.transform.rotation = entities[i].charRotation.rotation;
                    entities[i].charRotation.dirty = false;
                }
            }
        }
    }
}
