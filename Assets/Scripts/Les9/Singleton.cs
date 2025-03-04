using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Класс Singleton<T> наследуется от MonoBehaviour и реализует паттерн Singleton для классов типа T
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // Статическое поле, указывающее, завершает ли приложение свою работу
    public static bool isApplicationQuitting;

    // Статическое поле для хранения экземпляра класса Singleton<T>
    private static T _instance;

    // Объект для блокировки синхронизации потоков
    private static System.Object _lock = new System.Object();

    // Статическое свойство для доступа к экземпляру Singleton<T>
    public static T Instance
    {
        get
        {
            // Если приложение завершает работу, возвращаем null, чтобы предотвратить создание нового экземпляра
            if (isApplicationQuitting)
                return null;

            // Блокируем доступ к экземпляру для обеспечения потокобезопасности
            lock (_lock)
            {
                // Если экземпляр еще не создан, создаем его
                if (_instance == null)
                {
                    // Ищем существующий экземпляр типа T в сцене
                    _instance = FindObjectOfType<T>();

                    // Если экземпляр не найден, создаем новый GameObject с компонентом типа T
                    if (_instance == null)
                    {
                        // Создаем новый GameObject с именем "[SINGLETON] <имя_типа>"
                        var singleton = new GameObject("[SINGLETON] " + typeof(T));

                        // Добавляем компонент типа T к новому GameObject
                        _instance = singleton.AddComponent<T>();

                        // Указываем, что данный объект не должен уничтожаться при загрузке новой сцены
                        DontDestroyOnLoad(singleton);
                    }
                }

                // Возвращаем экземпляр Singleton<T>
                return _instance;
            }
        }
    }

    // Виртуальный метод OnDestroy, вызываемый при уничтожении объекта
    public virtual void OnDestroy()
    {
        // Устанавливаем флаг isApplicationQuitting в true, чтобы предотвратить создание нового экземпляра
        isApplicationQuitting = true;
    }
}