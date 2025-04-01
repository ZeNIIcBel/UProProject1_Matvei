using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Класс BuilderCharacter реализует интерфейс ICharacterBuilder для применения паттерна Builder
public class BuilderCharacter : ICharacterBuilder
{
    // Поля для хранения настроек персонажа
    private CharacterSettings prefabs; // Префаб, который будет использоваться для создания персонажа
    private string prefabName; // Имя персонажа
    private CharacterStats prefabCharacterStats; // Статистика персонажа (сила, ловкость, интеллект и т.д.)
    private Avatar avatar; // Аватар персонажа
    private RuntimeAnimatorController controller; // Контроллер анимации персонажа

    // Метод для установки аватара персонажа
    public ICharacterBuilder SetAvatar(Avatar avatar)
    {
        this.avatar = avatar; // Сохраняем переданный аватар
        return this; // Возвращаем текущий объект для цепочки вызовов
    }

    // Метод для установки контроллера анимации
    public ICharacterBuilder SetController(RuntimeAnimatorController controller)
    {
        this.controller = controller; // Сохраняем контроллер анимации
        return this; // Возвращаем текущий объект для цепочки вызовов
    }

    // Метод для задания статистики персонажа
    public ICharacterBuilder SetStats(CharacterStats prefabCharacterStats)
    {
        this.prefabCharacterStats = prefabCharacterStats; // Устанавливаем статистику персонажа
        return this; // Возвращаем текущий объект для цепочки вызовов
    }

    // Метод для задания имени персонажа
    public ICharacterBuilder SetName(string name)
    {
        this.prefabName = name; // Сохраняем имя персонажа
        return this; // Возвращаем текущий объект для цепочки вызовов
    }

    // Метод для указания префаба, из которого будет создаваться персонаж
    public ICharacterBuilder SetPrefabs(CharacterSettings prefabs)
    {
        this.prefabs = prefabs; // Сохраняем префаб
        return this; // Возвращаем текущий объект для цепочки вызовов
    }

    // Метод Build создает объект персонажа с указанными настройками
    public CharacterSettings Build()
    {
        // Создаём копию префаба с помощью метода Instantiate
        CharacterSettings characterSettings = Object.Instantiate(prefabs);

        // Устанавливаем имя для персонажа
        characterSettings.SetName(prefabName);

        // Устанавливаем статистику персонажа
        characterSettings.SetStats(prefabCharacterStats);

        // Добавляем компонент для работы с анимациями
        CharacterAnim characterAnim = characterSettings.gameObject.AddComponent<CharacterAnim>();

        // Инициализируем аниматор, назначаем аватар и контроллер
        characterAnim.FindAnimator();
        characterAnim.SetAvatar(avatar);
        characterAnim.SetController(controller);
        Debug.Log(characterSettings.ToString());

        // Возвращаем окончательные настройки персонажа
        return characterSettings;
    }

    // Метод Reset сбрасывает настройки билдера для создания нового персонажа
    public ICharacterBuilder Reset()
    {
        prefabs = null; // Сбрасываем префаб
        prefabCharacterStats = null; // Сбрасываем статистику
        prefabName = null; // Сбрасываем имя
        avatar = null; // Сбрасываем аватар
        controller = null; // Сбрасываем контроллер

        return this; // Возвращаем текущий объект для цепочки вызовов
    }
}





