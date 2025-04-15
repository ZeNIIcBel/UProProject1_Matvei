using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorMagic : CreatorCharacter
{
    ICharacterBuilder character = new BuilderCharacter();
    public override void CreateCharacter(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle1 = character
                                    .Reset() // Сбрасываем параметры билдера, чтобы начать с чистого листа
                                    .SetPrefabs(prefab) // Указываем префаб магического персонажа
                                    .SetName("Magic") // Задаём имя персонажу
                                    .SetStats(new CharacterStats(5, 10, 3)) // Устанавливаем параметры: сила, ловкость, интеллект
                                    .SetAvatar(null) // Аватар остаётся null
                                    .SetController(controller) // Присваиваем контроллер анимации
                                    .Build();
    }
}

