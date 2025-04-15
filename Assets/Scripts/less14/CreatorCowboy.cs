using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorCowboy : CreatorCharacter
{
    ICharacterBuilder character = new BuilderCharacter();
    public override void CreateCharacter(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle2 = character
                                .Reset() // Сбрасываем параметры билдера, чтобы начать с чистого листа
                                .SetPrefabs(prefab) // Указываем префаб магического персонажа
                                .SetName("Cowboy") // Задаём имя персонажу
                                .SetStats(new CharacterStats(200, 10000, 30000000)) // Устанавливаем параметры: сила, ловкость, интеллект
                                .SetAvatar(null) // Аватар остаётся null
                                .SetController(controller) // Присваиваем контроллер анимации
                                .Build(); // Завершаем создание и получаем настройки персонажа
    }

   
}
