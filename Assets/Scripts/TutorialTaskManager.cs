using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Sirenix.OdinInspector;

public class TutorialTaskManager : MonoBehaviour
{
    [Header("Cola de prioridad de tareas")]
    [SerializeField] private CustomPriorityQueue<Task> taskQueue = new CustomPriorityQueue<Task>();

    [Header("UI Elements")]
    [SerializeField] public TextMeshProUGUI taskText1;
    //[SerializeField] public TextMeshProUGUI taskText2;

    [Button("Asignar tareas")]
    public void AssignTask()
    {
        taskQueue.Clear();

        taskQueue.Enqueue(new Task(Task.TaskType.Buscar), 1);
        taskQueue.Enqueue(new Task(Task.TaskType.Recolectar), 2);
        taskQueue.Enqueue(new Task(Task.TaskType.Derrotar), 3);
        taskQueue.Enqueue(new Task(Task.TaskType.Hablar), 4);

        UpdateTaskText();
        Debug.Log("Lista de tareas iniciada.");
    }
    [Button("Completar tarea actual")]
    public void CompleteCurrentTask()
    {
        if(taskQueue.Count <= 0)
        {
            taskText1.text = "Todas las tareas completadas.";
            Debug.Log("No hay más tareas");
            return;
        }
        Task completedTask = taskQueue.Dequeue();
        Debug.Log("Tarea completada: " + completedTask.Type);
        UpdateTaskText();
    }
    public void UpdateTaskText()
    {
        if(taskQueue.Count > 0)
        {
            taskQueue.TryPeek(out var currentTaskNode, out int prio);
            taskText1.text = "Tarea Prioritaria: " + currentTaskNode.Value.GetTaskMessage();
            //taskText2.text = taskQueue.GetAllTasks();
        }
        else
        {
            taskText1.text = "No hay tareas pendientes";
        }
    }
}