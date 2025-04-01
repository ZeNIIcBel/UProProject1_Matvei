using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLes13 : MonoBehaviour
{
    // Импортируемые настройки персонажа, которые можно настроить в инспекторе Unity
    [SerializeField]
    CharacterSettings ordinary; // Настройки для обычного персонажа
    [SerializeField]
    CharacterSettings magic; // Настройки для магического персонажа
    [SerializeField]
    CharacterSettings cowboy; // Настройки для ковбоя

    [SerializeField]
    RuntimeAnimatorController controller; // Контроллер анимации, который задаёт поведение анимации для персонажей

    private void Start()
    {
        // Создаём объект Builder для построения персонажей через паттерн Builder
        ICharacterBuilder character = new BuilderCharacter();

        // Создаём персонажа с настройками "обычный"
        CharacterSettings idle = character
                            .Reset() // Сбрасываем параметры билдера, чтобы начать с нуля
                            .SetPrefabs(ordinary) // Указываем префаб обычного персонажа
                            .SetName("Odrinary") // Задаём имя персонажу
                            .SetStats(new CharacterStats(10, 3, 1)) // Устанавливаем параметры: сила, ловкость, интеллект
                            .SetAvatar(null) // Указываем, что аватар пока не задан (null)
                            .SetController(controller) // Присваиваем контроллер анимации
                            .Build(); // Завершаем создание персонажа и возвращаем его настройки

        // Создаём персонажа с настройками "магический"
        CharacterSettings idle1 = character
                                    .Reset() // Сбрасываем параметры билдера, чтобы начать с чистого листа
                                    .SetPrefabs(magic) // Указываем префаб магического персонажа
                                    .SetName("Magic") // Задаём имя персонажу
                                    .SetStats(new CharacterStats(5, 10, 3)) // Устанавливаем параметры: сила, ловкость, интеллект
                                    .SetAvatar(null) // Аватар остаётся null
                                    .SetController(controller) // Присваиваем контроллер анимации
                                    .Build(); 
        CharacterSettings idle2 = character
                                    .Reset() // Сбрасываем параметры билдера, чтобы начать с чистого листа
                                    .SetPrefabs(cowboy) // Указываем префаб магического персонажа
                                    .SetName("Cowboy") // Задаём имя персонажу
                                    .SetStats(new CharacterStats(200, 10000, 30000000)) // Устанавливаем параметры: сила, ловкость, интеллект
                                    .SetAvatar(null) // Аватар остаётся null
                                    .SetController(controller) // Присваиваем контроллер анимации
                                    .Build(); // Завершаем создание и получаем настройки персонажа
    }
}
