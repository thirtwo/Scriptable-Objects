
public interface IBreakable
{
    float Health { get; set; }
    void Damage(float damage, int resist);
    void Break(float health);
}
public interface IOpenable
{
    void OpenClose(bool willOpen);
}
