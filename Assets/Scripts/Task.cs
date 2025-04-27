using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task
{
    private TaskType _type;
    public enum TaskType
    {
        Buscar,
        Recolectar,
        Derrotar,
        Hablar
    }
    public TaskType Type
    {
        get
        {
            return _type;
        }
        private set
        {
            _type = value;
        }
    }
    public Task(TaskType type)
    {
        Type = type;
    }
    public string GetTaskMessage()
    {
        switch (Type)
        {
            case TaskType.Buscar:
                return "Debes buscar un objeto perdido.";
            case TaskType.Recolectar:
                return "Recolecta los materiales necesarios.";
            case TaskType.Derrotar:
                return "Derrota al enemigo.";
            case TaskType.Hablar:
                return "Habla con el aldeano.";
            default:
                return "Tarea desconocida";
        }
    }
}
