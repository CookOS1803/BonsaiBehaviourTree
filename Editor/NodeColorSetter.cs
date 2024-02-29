using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bonsai.Designer
{
  public interface INodeColorSetter
  {
    public Color NodeTypeColor(BonsaiNode node);
  }

  public class NodeColorSetter : INodeColorSetter
  {
    public Color NodeTypeColor(BonsaiNode node)
    {
      if (node.Behaviour is Core.Task)
      {
        return BonsaiPreferences.Instance.taskColor;
      }

      else if (node.Behaviour is Core.Service)
      {
        return BonsaiPreferences.Instance.serviceColor;
      }

      else if (node.Behaviour is Core.ConditionalAbort)
      {
        return BonsaiPreferences.Instance.conditionalColor;
      }

      else if (node.Behaviour is Core.Decorator)
      {
        return BonsaiPreferences.Instance.decoratorColor;
      }

      return BonsaiPreferences.Instance.compositeColor;
    }
  }
}
