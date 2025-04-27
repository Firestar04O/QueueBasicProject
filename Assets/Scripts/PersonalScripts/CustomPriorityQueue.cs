using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPriorityQueue<T> : PriorityQueue<T>
{
    //intento de hacer aparecer las task pendientes
    //public string GetAllTasks()
    //{
    //    return ReadQueueToString();
    //}
    //private string ReadQueueToString(PriorityQueueNode<T> _current = null, int depth = 0)
    //{
    //    if (depth >= count)
    //        return "";

    //    if (_current == null)
    //        _current = last;

    //    if (_current == null)
    //        return "No tasks available.";

    //    string currentTask = "Task " + (count - depth) + ": " + _current.Value.GetType().ToString() + "\n";
    //    return currentTask + ReadQueueToString(_current.Next, depth + 1);
    //}
}
