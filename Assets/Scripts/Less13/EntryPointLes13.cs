using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLes13 : MonoBehaviour
{
    // ������������� ��������� ���������, ������� ����� ��������� � ���������� Unity
    [SerializeField]
    CharacterSettings ordinary; // ��������� ��� �������� ���������
    [SerializeField]
    CharacterSettings magic; // ��������� ��� ����������� ���������
    [SerializeField]
    CharacterSettings cowboy; // ��������� ��� ������

    [SerializeField]
    RuntimeAnimatorController controller; // ���������� ��������, ������� ����� ��������� �������� ��� ����������

    private void Start()
    {
        // ������ ������ Builder ��� ���������� ���������� ����� ������� Builder
        ICharacterBuilder character = new BuilderCharacter();

        // ������ ��������� � ����������� "�������"
        CharacterSettings idle = character
                            .Reset() // ���������� ��������� �������, ����� ������ � ����
                            .SetPrefabs(ordinary) // ��������� ������ �������� ���������
                            .SetName("Odrinary") // ����� ��� ���������
                            .SetStats(new CharacterStats(10, 3, 1)) // ������������� ���������: ����, ��������, ���������
                            .SetAvatar(null) // ���������, ��� ������ ���� �� ����� (null)
                            .SetController(controller) // ����������� ���������� ��������
                            .Build(); // ��������� �������� ��������� � ���������� ��� ���������

        // ������ ��������� � ����������� "����������"
        CharacterSettings idle1 = character
                                    .Reset() // ���������� ��������� �������, ����� ������ � ������� �����
                                    .SetPrefabs(magic) // ��������� ������ ����������� ���������
                                    .SetName("Magic") // ����� ��� ���������
                                    .SetStats(new CharacterStats(5, 10, 3)) // ������������� ���������: ����, ��������, ���������
                                    .SetAvatar(null) // ������ ������� null
                                    .SetController(controller) // ����������� ���������� ��������
                                    .Build(); 
        CharacterSettings idle2 = character
                                    .Reset() // ���������� ��������� �������, ����� ������ � ������� �����
                                    .SetPrefabs(cowboy) // ��������� ������ ����������� ���������
                                    .SetName("Cowboy") // ����� ��� ���������
                                    .SetStats(new CharacterStats(200, 10000, 30000000)) // ������������� ���������: ����, ��������, ���������
                                    .SetAvatar(null) // ������ ������� null
                                    .SetController(controller) // ����������� ���������� ��������
                                    .Build(); // ��������� �������� � �������� ��������� ���������
    }
}
