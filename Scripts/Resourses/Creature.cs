using Godot;

public partial class Creature : Resource 
{
    public string name;

    [Export(hintString: "Vigor")]
    public int Vigor;
    [Export(hintString: "Reflex")]
    public int Reflex;
    [Export(hintString: "Cognition")]
    public int Cognition;
    [Export(hintString: "Willpower")]
    public int Willpower;

    private int _health;
    public int Health {get {return _health;} set {_health = value;}}
    public int armor;
    public void ApplyDamage(int damage)
    {
        //some fancy damage reduction formula here later
        int value = damage - armor;
        Health -= value > 0 ? value : 1;
    }

    [Export(hintString: "Damage")]
    public int damage;
}