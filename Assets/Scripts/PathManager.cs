using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UIElements;

public class PathManager : MonoBehaviour
{
    public Path path;

    private void OnDrawGizmos()
    {
        if (path == null || path.Nodes == null)
        {
            return;
        }
        Gizmos.color = Color.blue;
        foreach (var pathValue in path.Nodes)
        {
            Vector3 position = pathValue.Value.Key;
            Gizmos.DrawSphere(position, 0.2f);
            foreach(var neighbor in pathValue.Value.Neighbors)
            {
                Gizmos.DrawLine(position, neighbor.Key);
            }
        }
    }

    [Button]
    public void AddNodeOfPath()
    {
        string nodeName = "Nodo" + path.Nodes.Count;
        Vector3 position = transform.position;
        path.AddNode(nodeName, position);
        Debug.Log(nodeName + " en posición " + position + " agregado.");
    }

    [Button]
    public void LastTwoNodesConnection()
    {
        if(path.Nodes.Count >= 2)
        {
            var keys = new List<string>(path.Nodes.Keys);
            string last = keys[keys.Count - 1];
            string lastlast = keys[keys.Count - 2];
            path.AddEdge(last, lastlast);
            Debug.Log(last + " y " + lastlast + " conectados.");
        }
    }

    [Button]
    public void DeletePaths()
    {
        path.Nodes.Clear();
        Debug.Log("Rutras eliminadas");
    }
}