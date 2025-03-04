using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� Singleton<T> ����������� �� MonoBehaviour � ��������� ������� Singleton ��� ������� ���� T
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // ����������� ����, �����������, ��������� �� ���������� ���� ������
    public static bool isApplicationQuitting;

    // ����������� ���� ��� �������� ���������� ������ Singleton<T>
    private static T _instance;

    // ������ ��� ���������� ������������� �������
    private static System.Object _lock = new System.Object();

    // ����������� �������� ��� ������� � ���������� Singleton<T>
    public static T Instance
    {
        get
        {
            // ���� ���������� ��������� ������, ���������� null, ����� ������������� �������� ������ ����������
            if (isApplicationQuitting)
                return null;

            // ��������� ������ � ���������� ��� ����������� ������������������
            lock (_lock)
            {
                // ���� ��������� ��� �� ������, ������� ���
                if (_instance == null)
                {
                    // ���� ������������ ��������� ���� T � �����
                    _instance = FindObjectOfType<T>();

                    // ���� ��������� �� ������, ������� ����� GameObject � ����������� ���� T
                    if (_instance == null)
                    {
                        // ������� ����� GameObject � ������ "[SINGLETON] <���_����>"
                        var singleton = new GameObject("[SINGLETON] " + typeof(T));

                        // ��������� ��������� ���� T � ������ GameObject
                        _instance = singleton.AddComponent<T>();

                        // ���������, ��� ������ ������ �� ������ ������������ ��� �������� ����� �����
                        DontDestroyOnLoad(singleton);
                    }
                }

                // ���������� ��������� Singleton<T>
                return _instance;
            }
        }
    }

    // ����������� ����� OnDestroy, ���������� ��� ����������� �������
    public virtual void OnDestroy()
    {
        // ������������� ���� isApplicationQuitting � true, ����� ������������� �������� ������ ����������
        isApplicationQuitting = true;
    }
}