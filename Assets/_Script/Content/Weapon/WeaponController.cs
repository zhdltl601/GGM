using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour,IGetCompoable, IAfterInitable
{
    public List<WeaponCompo> weaponList = new List<WeaponCompo>();//���⸮��Ʈ

    protected int _bFireHash, _bReloadHash, _fAmmoHash;//b:bool,t:Trigger,f:float;

    [SerializeField]
    protected AudioSource _audioSource;

    protected Agent _agent;
    protected PlayerWeaponAnim _weaponAnime;

    public virtual void Init(Agent agent)
    {
        _agent = agent;
    }
    public virtual void AfterInit()
    {
        _weaponAnime = _agent.GetCompo<PlayerWeaponAnim>();
    }


}
