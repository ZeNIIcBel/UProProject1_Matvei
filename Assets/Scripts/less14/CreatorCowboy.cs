using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorCowboy : CreatorCharacter
{
    ICharacterBuilder character = new BuilderCharacter();
    public override void CreateCharacter(CharacterSettings prefab, RuntimeAnimatorController controller)
    {
        CharacterSettings idle2 = character
                                .Reset() // ���������� ��������� �������, ����� ������ � ������� �����
                                .SetPrefabs(prefab) // ��������� ������ ����������� ���������
                                .SetName("Cowboy") // ����� ��� ���������
                                .SetStats(new CharacterStats(200, 10000, 30000000)) // ������������� ���������: ����, ��������, ���������
                                .SetAvatar(null) // ������ ������� null
                                .SetController(controller) // ����������� ���������� ��������
                                .Build(); // ��������� �������� � �������� ��������� ���������
    }

   
}
