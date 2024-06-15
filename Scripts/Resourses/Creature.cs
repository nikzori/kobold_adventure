using Godot;

public partial class Creature : Resource 
{
    public string name;

    private int _health;
    public int Health {get {return _health;} set {_health = value;}}
    public int armor;
    public void ApplyDamage(int damage)
    {
        //some fancy damage reduction formula here later
        Health -= damage;
    }
}