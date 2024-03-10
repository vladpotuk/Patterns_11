using System;
using System.Collections.Generic;

public class ShapeRegistry
{
    private Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

    public void AddShape(string key, IShape shape)
    {
        if (!shapes.ContainsKey(key))
        {
            shapes.Add(key, shape);
        }
    }

    public void RemoveShape(string key)
    {
        if (shapes.ContainsKey(key))
        {
            shapes.Remove(key);
        }
    }

   
    public IShape GetShape(string key)
    {
        if (shapes.ContainsKey(key))
        {
            return shapes[key];
        }
        return null;
    }
}

