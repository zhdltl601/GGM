using UnityEngine;

[CreateAssetMenu(fileName = "AnimHashSO", menuName = "SO/AnimHashSO")]
public class AnimHashSO : ScriptableObject
{
    public string name;
    public int hashCode { get; private set; }


    private void OnValidate()
    {
        hashCode = Animator.StringToHash(name);
        //���ΰ�ħ/���� �� ������Ʈ��.
    }
}
