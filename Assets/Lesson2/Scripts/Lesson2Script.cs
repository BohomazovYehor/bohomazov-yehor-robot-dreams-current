using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson2Script : MonoBehaviour
{
    [SerializeField] private string _value;

    private List<string> _list = new();

    [ContextMenu("Add to list")]
    private void AddToList()
    {
        _list.Add(_value);
        Debug.Log($"{_value} added to list");
    }

    [ContextMenu("Remove From list")]
    private void RemoveFromList()
    {
        _list.Remove(_value);
        Debug.Log($"{_value} removed from list");
    }

    [ContextMenu("Sort List")]
    private void SortList()
    {
        _list.Sort();
        Debug.Log("List sorted");
    }

    [ContextMenu("Print list")]
    private void PrintList()
    {
        if (_list.Count < 1)
        {
            Debug.Log("List must not be empty, please add some values to it");
        }
        else
        {
            string msg = $"List: {_list[0]}";
            for (int i = 1; i < _list.Count; i++)
            {
                msg += $", {_list[i]}";
            }
            Debug.Log(msg);
        }
    }

    [ContextMenu("Clean list")]
    private void CleanList()
    {
        _list.Clear();
        Debug.Log("List cleaned");
    }
}
